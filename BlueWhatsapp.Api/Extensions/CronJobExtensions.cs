using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Persistence;
using Quartz;

namespace BlueWhatsapp.Api.Extensions;

internal static class CronJobExtensions
{
    public class DeleteOldFoldersJob : IJob
    {
        private readonly IAppLogger _logger;

        public DeleteOldFoldersJob(IAppLogger logger)
        {
            _logger = logger;
        }

        Task IJob.Execute(IJobExecutionContext context)
        {
            string rootDirectory = Path.Combine(Directory.GetCurrentDirectory(), "logs");

            if (!Directory.Exists(rootDirectory))
            {
                _logger.LogInfo("Logs directory does not exist.");
                return Task.CompletedTask;
            }

            var directories = Directory.GetDirectories(rootDirectory);

            foreach (var directory in directories)
            {
                var creationTime = Directory.GetCreationTime(directory);

                if (creationTime >= DateTime.Today)
                {
                    continue;
                }

                try
                {
                    Directory.Delete(directory, true);
                    _logger.LogInfo($"Deleted folder: {directory}");
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Failed to delete folder: {directory}. Error: {ex.Message}");
                }
            }

            return Task.CompletedTask;
        }
    }

    public class ResetTripCapacitiesJob : IJob
    {
        private readonly IAppLogger _logger;
        private readonly ITripRepository _tripRepository;

        public ResetTripCapacitiesJob(IAppLogger logger, ITripRepository tripRepository)
        {
            _logger = logger;
            _tripRepository = tripRepository;
        }

        async Task IJob.Execute(IJobExecutionContext context)
        {
            try
            {
                _logger.LogInfo("Starting daily trip capacity reset job");
                
                var trips = await _tripRepository.GetAllTripsAsync();
                foreach (var trip in trips)
                {
                    trip.MaxCapacity = 30;
                    await _tripRepository.UpdateTripAsync(trip);
                }
                
                _logger.LogInfo($"Successfully reset capacities for {trips.Count()} trips");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to reset trip capacities. Error: {ex.Message}");
            }
        }
    }

    internal static void ConfigureCronSchedulerJobs(this WebApplicationBuilder builder)
    {
        builder.Services.AddQuartz(q =>
        {
            q.UseMicrosoftDependencyInjectionJobFactory();

            // Configure DeleteOldFoldersJob
            var deleteFoldersJobKey = new JobKey("DeleteOldFoldersJob");
            q.AddJob<DeleteOldFoldersJob>(opts => opts.WithIdentity(deleteFoldersJobKey));

            q.AddTrigger(opts => opts
                .ForJob(deleteFoldersJobKey)
                .WithIdentity("DeleteOldFoldersTrigger")
                .WithSchedule(CronScheduleBuilder.WeeklyOnDayAndHourAndMinute(DayOfWeek.Monday, 0, 0))
            );

            // Configure ResetTripCapacitiesJob
            var resetCapacitiesJobKey = new JobKey("ResetTripCapacitiesJob");
            q.AddJob<ResetTripCapacitiesJob>(opts => opts.WithIdentity(resetCapacitiesJobKey));

            q.AddTrigger(opts => opts
                .ForJob(resetCapacitiesJobKey)
                .WithIdentity("ResetTripCapacitiesTrigger")
                .WithSchedule(CronScheduleBuilder.DailyAtHourAndMinute(23, 50))
            );
        });

        builder.Services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);
    }
}
using BlueWhatsapp.Core.Logger;
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

    internal static void ConfigureCronSchedulerJobs(this WebApplicationBuilder builder)
    {
        builder.Services.AddQuartz(q =>
        {
            q.UseMicrosoftDependencyInjectionJobFactory();

            var jobKey = new JobKey("DeleteOldFoldersJob");
            q.AddJob<DeleteOldFoldersJob>(opts => opts.WithIdentity(jobKey));

            q.AddTrigger(opts => opts
                .ForJob(jobKey)
                .WithIdentity("DeleteOldFoldersTrigger")
                .WithSchedule(CronScheduleBuilder.WeeklyOnDayAndHourAndMinute(DayOfWeek.Monday, 0, 0))
            );
        });

        builder.Services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);
    }
}
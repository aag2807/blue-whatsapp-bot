using System.Security.Cryptography.X509Certificates;
using BlueWhatsapp.Boundaries.Persistence.Models;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Persistence;
using Microsoft.EntityFrameworkCore;
using Triplex.Validations;

namespace BlueWhatsapp.Boundaries.Persistence.Repositories.Implementation;

public sealed class ConversationStateRepository : BaseRepository<ConversationState>, IConversationStateRepository
{
    /// <summary>
    /// Represents the repository responsible for managing operations related to ConversationState entities.
    /// This repository serves as the implementation of the IConversationStateRepository interface
    /// and provides methods inherited from the BaseRepository to perform CRUD operations on the ConversationState entity.
    /// </summary>
    public ConversationStateRepository(IWhatsappBlueContext dbContext, IAppLogger logger) : base(dbContext, logger)
    {
    }

    /// <inheritdoc />
    async Task<CoreConversationState?> IConversationStateRepository.GetConversationStateByNumber(string number)
    {
        Arguments.NotEmptyOrWhiteSpaceOnly(number, nameof(number));
        var today = DateTime.UtcNow.Date;

        ConversationState? model = await _dbSet
            .Where(e => e.CreatedTime.Date == today)
            .FirstOrDefaultAsync(cs => cs.UserNumber.Trim() == number.Trim())
            .ConfigureAwait(true);
        
        return model is null ? null : CoreConversationState.Create(model);
    }

    /// <inheritdoc />
    async Task IConversationStateRepository.PersistAsync(CoreConversationState state)
    {
        Arguments.NotNull(state, nameof(state));
        ConversationState model = ConversationState.FromCore(state);

        await AddAsync(model).ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task IConversationStateRepository.UpdateAsync(CoreConversationState state)
    {
        ConversationState model = await _dbSet.FirstOrDefaultAsync(cs => cs.UserNumber.Trim() == state.UserNumber.Trim()).ConfigureAwait(true)!;

        model.CurrentStep = state.CurrentStep;
        model.IsAdminOverridden = state.IsAdminOverridden;
        model.IsComplete = state.IsComplete;
        model.ModifiedTime = DateTime.UtcNow;
        model.LanguageId = state.LanguageId;
        model.ZoneId = state.ZoneId;
        model.ScheduleId = state.ScheduleId;
        model.HotelId = state.HotelId;
        model.UserNumber = state.UserNumber;
        model.PersonName = state.PersonName;
        model.PickUpDate = state.PickUpDate;
        model.FullName = state.FullName;
        model.RoomNumber = state.RoomNumber;
        model.Email = state.Email;
        model.Adults = state.Adults;
        model.Children = state.Children;
        model.Flow = state.Flow;
        
        await UpdateAsync(model).ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreConversationState>> IConversationStateRepository.GetAllConversationsAsync()
    {   
        List<ConversationState> model = await _dbSet.ToListAsync().ConfigureAwait(true);
        if(model.Count == 0)
        {
            return Enumerable.Empty<CoreConversationState>();
        }

        return model.Select(m => CoreConversationState.Create(m))
            .DistinctBy(c => c.UserNumber)
            .ToList();
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreConversationState>> IConversationStateRepository.GetPendingConversationsFromTodayAsync()
    {
         List<ConversationState> response =  await GetAllActiveQuery()
            .Where(cs => cs.IsComplete == false)
            .ToListAsync()
            .ConfigureAwait(true);
         
         return response.Select(CoreConversationState.Create);
    }
    
    /// <inheritdoc />
    async Task<IEnumerable<CoreConversationState>> IConversationStateRepository.GetCompletedConversationsFromTodayAsync()
    {
        List<ConversationState> response =  await GetAllActiveQuery()
            .Where(cs => cs.IsComplete == true)
            .ToListAsync()
            .ConfigureAwait(true);
         
        return response.Select(CoreConversationState.Create);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreConversationState>> IConversationStateRepository.GetAllConversationsThisWeekAsync()
    {
        DateTime today = DateTime.UtcNow.Date;
        int currentDayOfWeek = (int)today.DayOfWeek;
        DateTime startOfWeek = today.AddDays(-currentDayOfWeek);
        DateTime endOfWeek = startOfWeek.AddDays(7); 

        List<ConversationState> response = await _dbSet
            .Where(cs => cs.CreatedTime.Date >= startOfWeek && cs.CreatedTime.Date < endOfWeek)
            .ToListAsync()
            .ConfigureAwait(true);

        if (response.Count == 0)
        {
            return Enumerable.Empty<CoreConversationState>();
        }

        return response
            .Select(CoreConversationState.Create)
            .DistinctBy(c => c.UserNumber)
            .ToList();
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreConversationState>> IConversationStateRepository.GetRecentConversationsAsync(int count = 20)
    {
        List<ConversationState> response = await GetAllActiveQuery()
            .OrderByDescending(cs => cs.CreatedTime)
            .Take(count)
            .ToListAsync()
            .ConfigureAwait(true);

        return response.Select(CoreConversationState.Create);
    }
    
    /// <inheritdoc />
    async Task IConversationStateRepository.MarkConversationAsManuallyOverridenAsync(int conversationId)
    {
        ConversationState model = await _dbSet.FirstOrDefaultAsync(cs => cs.Id == conversationId).ConfigureAwait(true)!;
        model.IsAdminOverridden = true;
        await UpdateAsync(model).ConfigureAwait(true);
    }
    
    /// <inheritdoc />
    async Task<CoreConversationState> IConversationStateRepository.GetConversationStateById(int conversationId)
    {
        ConversationState model = await _dbSet.FirstOrDefaultAsync(cs => cs.Id == conversationId).ConfigureAwait(true)!;

        return CoreConversationState.Create(model);
    }
}
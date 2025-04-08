using BlueWhatsapp.Boundaries.Persistence.Models;
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
    public ConversationStateRepository(IWhatsappBlueContext dbContext) : base(dbContext)
    {
    }

    /// <inheritdoc>
    async Task<CoreConversationState?> IConversationStateRepository.GetConversationStateByNumber(string number)
    {
        Arguments.NotEmptyOrWhiteSpaceOnly(number, nameof(number));
        
        ConversationState? model = await _dbSet.FirstOrDefaultAsync(cs => cs.UserNumber.Trim() == number.Trim()).ConfigureAwait(true);
        
        return model is null ? null : CoreConversationState.Create(model);
    }

    /// <inheritdoc>
    async Task IConversationStateRepository.PersistAsync(CoreConversationState state)
    {
        Arguments.NotNull(state, nameof(state));
        ConversationState model = ConversationState.FromCore(state);

        await AddAsync(model).ConfigureAwait(true);
        
        await _dbContext.SaveChangesAsync().ConfigureAwait(true);
    }

    /// <inheritdoc>
    async Task IConversationStateRepository.UpdateAsync(CoreConversationState state)
    {
        ConversationState model = await _dbSet.FirstOrDefaultAsync(cs => cs.UserNumber.Trim() == state.UserNumber.Trim()).ConfigureAwait(true)!;

        model.CurrentStep = state.CurrentStep;
        model.IsAdminOverridden = state.IsAdminOverridden;
        model.IsComplete = state.IsComplete;

        await _dbContext.SaveChangesAsync().ConfigureAwait(true);
    }
}
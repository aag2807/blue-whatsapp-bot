using BlueWhatsapp.Api.models.DTO.Messages;

namespace BlueWhatsapp.Api.models.DTO;

public sealed class PaginatedResponse<T>
{
    /// <summary>
    /// The data of the paginated response
    /// </summary>
    public List<T> Data { get; set; } = Enumerable.Empty<T>().ToList();

    /// <summary>
    /// The total of the paginated response
    /// </summary>
    public int Total { get; set; }
        
    /// <summary>
    /// The page of the paginated response
    /// </summary>
    public int Page { get; set; }

    /// <summary>
    /// The page size of the paginated response
    /// </summary>
    public int PageSize { get; set; }
}

using ASPNet.API.Models.Domain;
using ASPNet.API.Models.DTOs;

namespace ASPNet.API.Repositories;

public interface IWalkRepository
{
    Task<Walk> CreateAsync(Walk walk);
    Task<List<Walk>> GetAllAsync(string? filterOn = null, string? filterQuery = null,
                                    string? sortBy = null, bool isAscending = true, 
                                        int pageNumber = 1, int pageSize = 10);
    Task<Walk?> GetByIdAsync(Guid id);
    Task<Walk?> UpdateByIdAsync(Guid id, Walk walk);
    Task<Walk?> DeleteByIdAsync(Guid id);
}
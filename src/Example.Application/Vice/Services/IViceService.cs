using Example.Application.Vice.Models.Request;
using Example.Application.Vice.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Example.Application.Vice.Services
{
    public interface IViceService
    {
        Task<ViceCreateResponse> CreateAsync(ViceCreateRequest request);
        Task<ViceGetAllResponse> GetAllAsync();
        Task<ViceGetOneResponse> GetOneAsync(int Id);
        Task<ViceUpdateResponse> UpdateAsync(int Id, ViceUpdateRequest request);
        Task<ViceDeleteResponse> DeleteAsync(int Id);
    }
}

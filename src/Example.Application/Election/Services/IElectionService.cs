using Example.Application.Election.Models.Request;
using Example.Application.Election.Models.Response;
using Example.Domain.ElectionAggregate;
using Example.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Example.Application.Election.Services
{
    public interface IElectionService
    {
        Task<ElectionCreateResponse> CreateAsync(ElectionCreateRequest request);
        Task<ElectionGetAllResponse> GetAllAsync();
        Task<ElectionGetOneResponse> GetOneAsync(int id);
        Task<ElectionUpdateResponse> UpdateAsync(int id, ElectionUpdateRequest request);
        Task<ElectionDeleteResponse> DeleteAsync(int id);

    }

}

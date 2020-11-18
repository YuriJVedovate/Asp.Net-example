using Example.Application.Candidato.Models.Request;
using Example.Application.Candidato.Models.Response;
using Example.Domain.CandidatoAggregate;
using Example.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Example.Application.Candidato.Services
{
    public interface ICandidatoService
    {
        Task<CandidatoCreateResponse> CreateAsync(CandidatoCreateRequest request);
        Task<CandidatoGetAllResponse> GetAllAsync();
        Task<CandidatoGetOneResponse> GetOneAsync(int id);
        Task<CandidatoUpdateResponse> UpdateAsync(int id, CandidatoUpdateRequest request);
        Task<CandidatoDeleteResponse> DeleteAsync(int id);

    }

}

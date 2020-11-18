using Example.Application.Partido.Models.Request;
using Example.Application.Partido.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Example.Application.Partido.Services
{
    public interface IPartidoService
    {
        Task<PartidoCreateResponse> CreateAsync(PartidoCreateRequest request);
        Task<PartidoGetAllResponse> GetAllAsync();
        Task<PartidoGetOneResponse> GetOneAsync(int id);
        Task<PartidoUpdateResponse> UpdateAsync(int id, PartidoUpdateRequest request);
        Task<PartidoDeleteResponse> DeleteAsync(int id);
    }
}

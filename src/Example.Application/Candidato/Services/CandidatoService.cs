using Example.Application.Common;
using Example.Application.Candidato.Models.Dtos;
using Example.Application.Candidato.Models.Request;
using Example.Application.Candidato.Models.Response;
using Example.Domain.CandidatoAggregate;
using Example.Domain.SeedWork;
using Example.Domain.SeedWork.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Application.Candidato.Services
{
    public class CandidatoService : BaseService, ICandidatoService
    {
        private readonly ICandidatoRepository _candidatoRepository;
        private readonly INotification _notification;

        public CandidatoService(ICandidatoRepository candidatoRepository, INotification notification) : base(notification)
        {
            _candidatoRepository = candidatoRepository;
            _notification = notification;
        }

        public async Task<CandidatoCreateResponse> CreateAsync(CandidatoCreateRequest request) => await ExecuteAsync(async () =>
        {
            var response = new CandidatoCreateResponse();
            var obj = CandidatoDomain.Create(request.Nome, request.PartidoId, request.Idade, request.Posicao, request.ViceId);
            obj.Validate(obj, new CandidatoValidator());
            if (!obj.Valid)
            {
                _notification.AddNotifications(obj.ValidationResult);
                return response;
            }
            await _candidatoRepository.InsertOrUpdateAsync(obj).ConfigureAwait(false);
            return response;
        });

        
        public async Task<CandidatoGetAllResponse> GetAllAsync() => await ExecuteAsync(async () =>
        {
            var response = new CandidatoGetAllResponse();
            var banco = await _candidatoRepository.GetAllAsync().ConfigureAwait(false);
            response.Itens.AddRange(banco.Select(x => (CandidatoDto)x).ToList());
            return response;
        });

        public async Task<CandidatoGetOneResponse> GetOneAsync(int id) => await ExecuteAsync(async () =>
        {
            var response = new CandidatoGetOneResponse();
            var banco = await _candidatoRepository.GetByIdAsync(id, false).ConfigureAwait(false);
            if (banco != null)
                response.Candidato = (CandidatoDto)banco;
            return response;
        });


        public async Task<CandidatoUpdateResponse> UpdateAsync(int id, CandidatoUpdateRequest request) => await ExecuteAsync(async () =>
        {
            var response = new CandidatoUpdateResponse();
            var Election = await _candidatoRepository.GetByIdAsync(id, false).ConfigureAwait(false);
            if (Election != null)
            {
                //Changing property
                Election.Update(request.Nome, request.PartidoId, request.Idade, request.Posicao, request.ViceId);

                //Validate
                Election.Validate(Election, new CandidatoValidator());
                if (!Election.Valid)
                {
                    _notification.AddNotifications(Election.ValidationResult);
                    return response;
                }

                await _candidatoRepository.UpdateAsync(Election).ConfigureAwait(false);
            }
            else
                throw new NotFoundException();
            return response;
        });

        public async Task<CandidatoDeleteResponse> DeleteAsync(int id) => await ExecuteAsync(async () =>
        {
            var response = new CandidatoDeleteResponse();
            var banco = await _candidatoRepository.GetByIdAsync(id, false).ConfigureAwait(false);
            if (banco != null)
                await _candidatoRepository.DeleteAsync(banco).ConfigureAwait(false);

            return response;
        });
    }
}

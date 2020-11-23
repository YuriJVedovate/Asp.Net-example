using Example.Application.Common;
using Example.Application.Partido.Models.Response;
using Example.Application.Partido.Models.Dtos;
using Example.Application.Partido.Models.Request;
using Example.Domain.PartidoAggregate;
using Example.Domain.SeedWork;
using Example.Domain.SeedWork.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Application.Partido.Services
{
    public class PartidoService : BaseService, IPartidoService
    {
        private readonly IPartidoRepository _partidoRepository;
        private readonly INotification _notification;
        public PartidoService(IPartidoRepository partidoRepository, INotification notification) : base(notification)
        {
            _partidoRepository = partidoRepository;
            _notification = notification;

        }

        public async Task<PartidoCreateResponse> CreateAsync(PartidoCreateRequest request) => await ExecuteAsync(async () =>
        {
            var response = new PartidoCreateResponse();
            var obj = PartidoDomain.Create(request.NamePartido, request.CiglaPartido, request.NumeroEleitoral);
            obj.Validate(obj, new PartidoValidator());
            if (!obj.Valid)
            {
                _notification.AddNotifications(obj.ValidationResult);
                return response;
            }
            await _partidoRepository.InsertOrUpdateAsync(obj).ConfigureAwait(false);
            return response;
        });

        public async Task<PartidoGetAllResponse> GetAllAsync() => await ExecuteAsync(async () =>
        {
            var response = new PartidoGetAllResponse();
            var banco = await _partidoRepository.GetAllAsync().ConfigureAwait(false);
            response.Itens.AddRange(banco.Select(x => (PartidoDto)x).ToList());
            return response;
        });

        public async Task<PartidoGetOneResponse> GetOneAsync(int id) => await ExecuteAsync(async () =>
        {
            var response = new PartidoGetOneResponse();
            var banco = await _partidoRepository.GetByIdAsync(id, false).ConfigureAwait(false);
            if (banco != null)
                response.Partido = (PartidoDto)banco;
            return response;
        });


        public async Task<PartidoUpdateResponse> UpdateAsync(int id, PartidoUpdateRequest request) => await ExecuteAsync(async () =>
        {
            var response = new PartidoUpdateResponse();
            var partido = await _partidoRepository.GetByIdAsync(id, false).ConfigureAwait(false);
            if (partido != null)
            {
                //Changing property
                partido.Update(request.NamePartido, request.CiglaPartido, request.NumeroEleitoral);

                //Validate
                partido.Validate(partido, new PartidoValidator());
                if (!partido.Valid)
                {
                    _notification.AddNotifications(partido.ValidationResult);
                    return response;
                }

                await _partidoRepository.UpdateAsync(partido).ConfigureAwait(false);
            }
            else
                throw new NotFoundException();
            return response;
        });

        public async Task<PartidoDeleteResponse> DeleteAsync(int id) => await ExecuteAsync(async () =>
        {
            var response = new PartidoDeleteResponse();
            var banco = await _partidoRepository.GetByIdAsync(id, false).ConfigureAwait(false);
            if (banco != null)
                await _partidoRepository.DeleteAsync(banco).ConfigureAwait(false);

            return response;
        });

    }
}





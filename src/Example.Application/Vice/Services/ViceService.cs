using Example.Application.Common;
using Example.Application.Vice.Models.Request;
using Example.Application.Vice.Models.Response;
using Example.Domain.SeedWork;
using Example.Domain.ViceAggregate;
using Example.Domain.SeedWork.Exceptions;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Example.Application.Vice.Models.Dtos;

namespace Example.Application.Vice.Services
{
    public class ViceService : BaseService, IViceService
    {
        private readonly IViceRepository _viceRepositoriy;
        private readonly INotification _notification;
        public ViceService(IViceRepository viceRepositoriy ,INotification notification) : base(notification)
        {
            _viceRepositoriy = viceRepositoriy;
            _notification = notification;
        }

        public async Task<ViceCreateResponse> CreateAsync(ViceCreateRequest request) => await ExecuteAsync(async () =>
        {
            var response = new ViceCreateResponse();
            var obj = ViceDomain.Create(request.Nome, request.PartidoId, request.Idade);
            obj.Validate(obj, new ViceValidator());
            if (!obj.Valid)
            {
                _notification.AddNotifications(obj.ValidationResult);
                return response;
            }

            await _viceRepositoriy.InsertOrUpdateAsync(obj).ConfigureAwait(false);
            return response;

        });

        public async Task<ViceGetAllResponse> GetAllAsync() => await ExecuteAsync(async () =>
        {
            var response = new ViceGetAllResponse();
            var banco = await _viceRepositoriy.GetAllAsync().ConfigureAwait(false);
            response.Itens.AddRange(banco.Select(x => (ViceDto)x).ToList());
            return response;

        });

        public async Task<ViceGetOneResponse> GetOneAsync(int Id) => await ExecuteAsync(async () =>
        {
            var response = new ViceGetOneResponse();
            var banco = await _viceRepositoriy.GetByIdAsync(Id, false).ConfigureAwait(false);
            if (banco != null)
                response.Vice = (ViceDto)banco;
            return response;
        });

        public async Task<ViceUpdateResponse> UpdateAsync(int Id, ViceUpdateRequest request) => await ExecuteAsync(async () =>
        {
            var response = new ViceUpdateResponse();
            var vice = await _viceRepositoriy.GetByIdAsync(Id, false).ConfigureAwait(false);
            if (vice != null)
            {
                vice.Update(request.Nome, request.PartidoId, request.Idade);
                vice.Validate(vice, new ViceValidator());

                if (!vice.Valid)
                {
                    _notification.AddNotifications(vice.ValidationResult);
                    return response;
                }

                await _viceRepositoriy.UpdateAsync(vice).ConfigureAwait(false);
            }
            else
                throw new NotFoundException();

            return response;

        });

        public async Task<ViceDeleteResponse> DeleteAsync(int Id) => await ExecuteAsync(async () =>
        {
            var response = new ViceDeleteResponse();
            var vice = await _viceRepositoriy.GetByIdAsync(Id, false).ConfigureAwait(false);
            if (vice != null)
                await _viceRepositoriy.DeleteAsync(vice).ConfigureAwait(false);
            
            return response;
        });
       

    }
}

using Example.Application.Common;
using Example.Application.Election.Models.Dtos;
using Example.Application.Election.Models.Request;
using Example.Application.Election.Models.Response;
using Example.Domain.ElectionAggregate;
using Example.Domain.SeedWork;
using Example.Domain.SeedWork.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Application.Election.Services
{
    public class ElectionService : BaseService, IElectionService
    {
        private readonly IElectionRepository _electionRepository;

        private readonly INotification _notification;

        public ElectionService(IElectionRepository electionRepository, INotification notification) : base(notification)
        {
            _electionRepository = electionRepository;
            _notification = notification;
        }

        public async Task<ElectionCreateResponse> CreateAsync(ElectionCreateRequest request) => await ExecuteAsync(async () =>
        {
            var response = new ElectionCreateResponse();
            var obj = ElectionDomain.Create(request.Name, request.Entourage, request.Age, request.Occupation, request.Patrimony, request.Vice);
            obj.Validate(obj, new ElectionValidator());
            if (!obj.Valid)
            {
                _notification.AddNotifications(obj.ValidationResult);
                return response;
            }
            await _electionRepository.InsertOrUpdateAsync(obj).ConfigureAwait(false);
            return response;
        });

        
        public async Task<ElectionGetAllResponse> GetAllAsync() => await ExecuteAsync(async () =>
        {
            var response = new ElectionGetAllResponse();
            var banco = await _electionRepository.GetAllAsync().ConfigureAwait(false);
            response.Itens.AddRange(banco.Select(x => (ElectionDto)x).ToList());
            return response;
        });

        public async Task<ElectionGetOneResponse> GetOneAsync(int id) => await ExecuteAsync(async () =>
        {
            var response = new ElectionGetOneResponse();
            var banco = await _electionRepository.GetByIdAsync(id, false).ConfigureAwait(false);
            if (banco != null)
                response.Election = (ElectionDto)banco;
            return response;
        });


        public async Task<ElectionUpdateResponse> UpdateAsync(int id, ElectionUpdateRequest request) => await ExecuteAsync(async () =>
        {
            var response = new ElectionUpdateResponse();
            var Election = await _electionRepository.GetByIdAsync(id, false).ConfigureAwait(false);
            if (Election != null)
            {
                //Changing property
                Election.Update(request.Name, request.Entourage, request.Age, request.Occupation, request.Patrimony, request.Vice);

                //Validate
                Election.Validate(Election, new ElectionValidator());
                if (!Election.Valid)
                {
                    _notification.AddNotifications(Election.ValidationResult);
                    return response;
                }

                await _electionRepository.UpdateAsync(Election).ConfigureAwait(false);
            }
            else
                throw new NotFoundException();
            return response;
        });

        public async Task<ElectionDeleteResponse> DeleteAsync(int id) => await ExecuteAsync(async () =>
        {
            var response = new ElectionDeleteResponse();
            var banco = await _electionRepository.GetByIdAsync(id, false).ConfigureAwait(false);
            if (banco != null)
                await _electionRepository.DeleteAsync(banco).ConfigureAwait(false);

            return response;
        });
    }
}

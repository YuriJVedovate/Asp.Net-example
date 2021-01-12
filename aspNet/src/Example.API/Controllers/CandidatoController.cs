using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Application.Candidato.Models.Request;
using Example.Application.Candidato.Services;
using Example.Domain.SeedWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger;

namespace Example.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoController : BaseController
    {
        private readonly ICandidatoService _candidatoService;

        public CandidatoController(ICandidatoService candidatoService, INotification notification) : base(notification)
        {
            _candidatoService = candidatoService;
        }


        [HttpPost]
        public async Task<IActionResult> PostAsync(CandidatoCreateRequest request) => Response(await _candidatoService.CreateAsync(request).ConfigureAwait(false));

        [HttpGet]
        public async Task<IActionResult> GetAsync() => Response(await _candidatoService.GetAllAsync().ConfigureAwait(false));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOneAsync([FromRoute] int id) => Response(await _candidatoService.GetOneAsync(id).ConfigureAwait(false));

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync([FromRoute] int id, [FromBody] CandidatoUpdateRequest request) => Response(await _candidatoService.UpdateAsync(id, request).ConfigureAwait(false));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id) => Response(await _candidatoService.DeleteAsync(id).ConfigureAwait(false));
    }
}

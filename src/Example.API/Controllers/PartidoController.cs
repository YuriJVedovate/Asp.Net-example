using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Application.Partido.Models.Request;
using Example.Application.Partido.Services;
using Example.Domain.SeedWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartidoController : BaseController
    {
        private readonly IPartidoService _partidoService;
        public PartidoController(IPartidoService partidoService, INotification notification) : base(notification)
        {
            _partidoService = partidoService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(PartidoCreateRequest request) => Response(await _partidoService.CreateAsync(request).ConfigureAwait(false));

        [HttpGet]
        public async Task<IActionResult> GetAsync() => Response(await _partidoService.GetAllAsync().ConfigureAwait(false));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOneAsync([FromRoute] int id) => Response(await _partidoService.GetOneAsync(id).ConfigureAwait(false));

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync([FromRoute] int id, [FromBody] PartidoUpdateRequest request) => Response(await _partidoService.UpdateAsync(id, request).ConfigureAwait(false));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id) => Response(await _partidoService.DeleteAsync(id).ConfigureAwait(false));
    }
}

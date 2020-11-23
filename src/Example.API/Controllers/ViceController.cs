using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Application.Vice.Models.Request;
using Example.Application.Vice.Services;
using Example.Domain.SeedWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViceController : BaseController
    {

        private readonly IViceService _viceService;
        public ViceController(IViceService viceService, INotification notification) : base(notification)
        {
            _viceService = viceService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(ViceCreateRequest request) => Response(await _viceService.CreateAsync(request).ConfigureAwait(false));

        [HttpGet]
        public async Task<IActionResult> GetAsync() => Response(await _viceService.GetAllAsync().ConfigureAwait(false));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOneAsync([FromRoute] int id) => Response(await _viceService.GetOneAsync(id).ConfigureAwait(false));

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync([FromRoute] int id, [FromBody] ViceUpdateRequest request) => Response(await _viceService.UpdateAsync(id, request).ConfigureAwait(false));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id) => Response(await _viceService.DeleteAsync(id).ConfigureAwait(false));

    }
}

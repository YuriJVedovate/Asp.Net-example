using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Application.Election.Models.Request;
using Example.Application.Election.Services;
using Example.Domain.SeedWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger;

namespace Example.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectionController : BaseController
    {
        private readonly IElectionService _electionService;

        public ElectionController(IElectionService electionService , INotification notification) : base(notification)
        {
            _electionService = electionService;
        }


        [HttpPost]
        public async Task<IActionResult> PostAsync(ElectionCreateRequest request) => Response(await _electionService.CreateAsync(request).ConfigureAwait(false));

        [HttpGet]
        public async Task<IActionResult> GetAsync() => Response(await _electionService.GetAllAsync().ConfigureAwait(false));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOneAsync([FromRoute] int id) => Response(await _electionService.GetOneAsync(id).ConfigureAwait(false));

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync([FromRoute] int id, [FromBody] ElectionUpdateRequest request) => Response(await _electionService.UpdateAsync(id, request).ConfigureAwait(false));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id) => Response(await _electionService.DeleteAsync(id).ConfigureAwait(false));
    }
}

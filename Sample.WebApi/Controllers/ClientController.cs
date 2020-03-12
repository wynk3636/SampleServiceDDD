using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sample.Domain;
using System.Net;
using Sample.Application.Model;
using Sample.Application.Query;
using Sample.Application.Command;

namespace Sample.WebApi.Controllers
{
    public class ClientController : BaseController
    {

        private readonly ILogger<xxxController> _logger;

        public ClientController(ILogger<xxxController> logger)
        {
            _logger = logger;
        }

        //query : read
        [HttpPost("GetClient")]
        [ProducesResponseType(typeof(ClientDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetClient([FromBody]GetClientQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        //query : read
        [HttpPost("GetClient/Category")]
        [ProducesResponseType(typeof(ClientCategoryDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetClientCategory([FromBody]GetClientQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        //command : create, update, delete
        [HttpPost("CreateClient")]
        public async Task<IActionResult> CreateClient([FromBody]CreateXxxCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}

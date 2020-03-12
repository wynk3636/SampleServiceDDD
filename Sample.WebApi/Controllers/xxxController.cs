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
    public class xxxController : BaseController
    {

        private readonly ILogger<xxxController> _logger;

        public xxxController(ILogger<xxxController> logger)
        {
            _logger = logger;
        }

        //query : read
        [HttpPost("GetXxx")]
        [ProducesResponseType(typeof(xxxDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetXxx([FromBody]GetXxxQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        //command : create, update, delete
        [HttpPost("CreateXxx")]
        public async Task<IActionResult> CreateXxx([FromBody]CreateXxxCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}

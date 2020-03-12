using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.WebApi.Controllers
{

    [ApiController]
    [Route("ap1/v1/[controller]")]
    public abstract class BaseController : ControllerBase
    {

        private IMediator _mediator;

        protected IMediator Mediator => _mediator ?? (_mediator = HttpContext.RequestServices.GetService<IMediator>());

        public BaseController()
        {
        }
    }
}

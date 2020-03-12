using System;
using MediatR;
using Sample.Application.Model;

namespace Sample.Application.Query
{
    public class GetClientQuery : IRequest<ClientDto>
    {

        public string id { get; set; }
    }
}

using System;
using MediatR;
using Sample.Application.Model;

namespace Sample.Application.Query
{
    public class GetXxxQuery : IRequest<xxxDto>
    {
        public string id { get; set; }
    }
}

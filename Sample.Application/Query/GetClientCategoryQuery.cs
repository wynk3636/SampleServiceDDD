using System;
using MediatR;
using Sample.Application.Model;

namespace Sample.Application.Query
{
    public class GetClientCategoryQuery : IRequest<ClientCategoryDto>
    {
        public string id { get; set; }
    }
}

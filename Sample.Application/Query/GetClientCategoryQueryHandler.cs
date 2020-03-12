using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Sample.Application.Model;
using Sample.Application.Repository;
using Sample.Domain.Entity;

namespace Sample.Application.Query
{
    public class GetClientCategoryQueryHandler : IRequestHandler<GetClientCategoryQuery, ClientCategoryDto>
    {

        private readonly IMapper _mapper;
        private readonly IClientProvider _provider;

        public GetClientCategoryQueryHandler(IMapper mapper, IClientProvider provider)
        {
            _mapper = mapper;
            _provider = provider;
        }

        public async Task<ClientCategoryDto> Handle(GetClientCategoryQuery request, CancellationToken cancellationToken)
        {
            Client client = await _provider.GetClient(request);

            if (client.age >= 18)
            {
                return new ClientCategoryDto { category = "Adult", canDrink = true };
            }
            else
            {
                return new ClientCategoryDto { category = "Child", canDrink = false };
            }
        }
    }
}

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
    public class GetClientQueryHandler : IRequestHandler<GetClientQuery, ClientDto>
    {

        private readonly IMapper _mapper;
        private readonly IClientProvider _provider;

        public GetClientQueryHandler(IMapper mapper, IClientProvider provider)
        {
            _mapper = mapper;
            _provider = provider;
        }

        public async Task<ClientDto> Handle(GetClientQuery request, CancellationToken cancellationToken)
        {
            Client client = await _provider.GetClient(request);

            return new ClientDto { id = client.id, age = client.age, name = client.name };
        }
    }
}

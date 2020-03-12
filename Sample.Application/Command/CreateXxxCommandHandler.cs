using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Sample.Application.Model;
using Sample.Application.Repository;
using Sample.Domain.Entity;

namespace Sample.Application.Command
{
    public class CreateXxxCommandHandler : IRequestHandler<CreateXxxCommand, xxxContext>
    {

        private readonly IMapper _mapper;
        private readonly IxxxProvider _provider;

        public CreateXxxCommandHandler(IMapper mapper, IxxxProvider provider)
        {
            _mapper = mapper;
            _provider = provider;
        }

        public async Task<xxxContext> Handle(CreateXxxCommand request, CancellationToken cancellationToken)
        {
            xxxEntity entity = await _provider.CreateXxxEntity(request);

            return new xxxContext { id = entity.id, name = entity.name };
            
        }
    }
}

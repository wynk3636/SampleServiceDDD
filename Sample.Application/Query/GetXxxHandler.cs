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

    public class GetXxxHandler : IRequestHandler<GetXxxQuery,xxxDto>
    {

        private readonly IMapper _mapper;
        private readonly IxxxProvider _provider;

        public GetXxxHandler(IMapper mapper, IxxxProvider provider)
        {
            _mapper = mapper;
            _provider = provider;
        }

        public async Task<xxxDto> Handle(GetXxxQuery request, CancellationToken cancellationToken)
        {
            xxxEntity entity = await _provider.GetXxxEntity(request);

            int age = entity.age;

            if (age >= 18)
            {
                return new xxxDto { age = entity.age, status = "Adult" };
            }
            else
            {
                return new xxxDto { age = entity.age, status = "Child" };
            }
        }
    }
}

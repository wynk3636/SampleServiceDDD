using System;
using System.Threading.Tasks;
using Sample.Application.Command;
using Sample.Application.Query;
using Sample.Domain.Entity;

namespace Sample.Application.Repository
{
    public interface IxxxProvider
    {
        Task<xxxEntity> GetXxxEntity(GetXxxQuery query);

        Task<xxxEntity> CreateXxxEntity(CreateXxxCommand command);
    }
}

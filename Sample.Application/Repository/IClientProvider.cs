using System;
using System.Threading.Tasks;
using Sample.Application.Command;
using Sample.Application.Query;
using Sample.Domain.Entity;

namespace Sample.Application.Repository
{
    public interface IClientProvider
    {

        Task<Client> GetClient(GetClientQuery query);

        Task<Client> GetClient(GetClientCategoryQuery query);

        //Task<bool> CreateXxxEntity(CreateXxxCommand command);
    }
}

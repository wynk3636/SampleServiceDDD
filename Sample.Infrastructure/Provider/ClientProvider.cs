using System;
using System.Threading.Tasks;
using Sample.Application.Command;
using Sample.Application.Query;
using Sample.Application.Repository;
using Sample.Domain.Entity;

namespace Sample.Infrastructure.Provider
{
    public class ClientProvider : IClientProvider
    {
        public ClientProvider()
        {
        }

        public Task<Client> GetClient(GetClientQuery query)
        {
            Client client = new Client { id = "a", name = "John", age = 18 };
            return Task.FromResult(client);
        }

        public Task<Client> GetClient(GetClientCategoryQuery query)
        {
            Client client = new Client { id = "a", name = "John", age = 18 };
            return Task.FromResult(client);
        }
    }
}

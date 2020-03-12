using System;
using System.Threading.Tasks;
using Sample.Application.Query;
using Sample.Application.Repository;
using Sample.Domain.Entity;

namespace Sample.Infrastructure.Provider
{
    public class xxxProvider : IxxxProvider
    {

        public Task<xxxEntity> GetXxxEntity(GetXxxQuery query)
        {
            // database process

            //this code is sample, so it do not access database.
            //And return assumption object
            xxxEntity entity = new xxxEntity { name = "John", age = 18 };
            return Task.FromResult(entity);
        }
    }
}

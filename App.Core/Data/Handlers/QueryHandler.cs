using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using App.Core.Abstraction.Cqrs;
using App.Core.Data.Query;
using App.Core.Domain;

namespace App.Core.Handlers
{
    public class QueryHandler : IAsyncQueryHandler<AllEntityQuery, IEnumerable<EntityBase>>
    {
        public async Task<IEnumerable<EntityBase>> Handle(AllEntityQuery query)
        {
            throw new NotImplementedException();
        }
    }
}

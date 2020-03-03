using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Abstraction.Cqrs
{
    public interface IAsyncQueryHandler<in TQuery, TResult>
    where TQuery: IQuery
    {
        Task<TResult> Handle(TQuery query);
    }
}

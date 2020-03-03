using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Abstraction.Cqrs
{
    public interface IAsyncCommandHandler<in TCommand>
    where TCommand: ICommand
    {
        Task HandleAsync(TCommand cmd);
    }
}

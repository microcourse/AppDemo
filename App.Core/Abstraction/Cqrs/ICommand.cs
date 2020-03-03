using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Abstraction.Cqrs
{
    public interface ICommand
    {
        Guid Id { get; set; }
    }
}

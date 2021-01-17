using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehriWanBelgeseli.Api.Domain.UnitOfWork
{
    interface IUnitOfWork {
        Task CompleteAsync();
    }
}

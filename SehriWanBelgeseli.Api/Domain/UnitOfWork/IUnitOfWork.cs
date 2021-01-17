using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehriWanBelgeseli.Api.Domain.UnitOfWork
{
    public interface IUnitOfWork {
        Task CompleteAsync();
    }
}

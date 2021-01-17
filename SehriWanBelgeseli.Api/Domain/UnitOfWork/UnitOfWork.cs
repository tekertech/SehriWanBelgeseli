using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehriWanBelgeseli.Api.Domain.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SehriWanBelgeselDBContext dBContext;

        public UnitOfWork(SehriWanBelgeselDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public async Task CompleteAsync()
        {
            await dBContext.SaveChangesAsync();
        }
    }
}

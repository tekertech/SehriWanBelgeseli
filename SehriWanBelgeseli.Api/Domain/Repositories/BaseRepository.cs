using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehriWanBelgeseli.Api.Domain.Repositories
{
    public class BaseRepository
    {
        protected readonly SehriWanBelgeselDBContext dbContext;
        public BaseRepository(SehriWanBelgeselDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}

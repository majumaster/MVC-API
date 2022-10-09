using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Entities;

namespace Example.DataAccessLayer.Repositories.Concrete
{
    public class BaseRepository
    {
        protected AddDbContext context;

        public BaseRepository()
        {
            context = AddDbContext.Create();
        }

    }
}

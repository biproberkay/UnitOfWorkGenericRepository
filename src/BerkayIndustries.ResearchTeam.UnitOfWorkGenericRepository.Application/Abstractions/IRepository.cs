using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerkayIndustries.UoWRepositoryFactory.Application.Abstractions 
{
    public interface IRepository<T>
    {
#if false
        DbSet<T> Table { get; } 
#endif
    }
}

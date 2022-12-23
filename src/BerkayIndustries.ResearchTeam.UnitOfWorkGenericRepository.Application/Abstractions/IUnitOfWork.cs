using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerkayIndustries.UoWRepositoryFactory.Application.Abstractions 
{
    public interface IUnitOfWork<TContext> : IDisposable
    {
        TContext Context { get; }
        void BeginTransaction();
        void Commit();
        Task CommitAsync(CancellationToken cancellationToken);
        void RollBack();
    }
}

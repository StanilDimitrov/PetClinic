using PetClinic.Domain.Common;
using System.Threading;
using System.Threading.Tasks;

namespace PetClinic.Application.Contracts
{
    public interface IRepository<in TEntity>
        where TEntity : IAggregateRoot
    {
        Task Save(TEntity entity, CancellationToken cancellationToken = default);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IListRepository<T>
    {
        Task<IEnumerable<T>> List();
    }
}

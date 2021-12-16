using System.Threading.Tasks;

namespace Domain.Interfaces.GenericsInterfaces
{
    public interface IAddRepository<T>
    {
        Task InsertAsync(T obj);
    }
}

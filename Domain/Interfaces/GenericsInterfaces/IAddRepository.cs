using System.Threading.Tasks;

namespace Domain.Interfaces.GenericsInterfaces
{
    public interface IAddRepository<T> where T : class
    {
        Task InsertAsync(T obj);
    }
}

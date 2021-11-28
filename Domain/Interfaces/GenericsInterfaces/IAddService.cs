using System.Threading.Tasks;

namespace Domain.Interfaces.GenericsInterfaces
{
    public interface IAddService<T> where T : class
    {
        Task Insert(T obj);
    }
}

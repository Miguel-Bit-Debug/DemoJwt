using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services.GenericsServices
{
    public interface IListServices<T>
    {
        Task<IEnumerable<T>> List();
    }
}

using System.Threading.Tasks;
using dataswitch.DTOs;

namespace dataswitch.data.interfaces
{
    public interface IMariaDBStuff
    {
        Task<int> AddAsync(api.Model.maria_models.Class_Patient p); 
        Task<int> UpdateAsync<T>(T entity) where T : class; 
        Task<int> DeleteAsync<T>(T entity) where T : class;
        Task<bool> SaveAll();
    }
}
using System.Threading.Tasks;

namespace WPFTodo.Api.Serivce
{
    public interface IBaseService<T>
    {
        Task<ApiResponse> GetAllAsync();

        Task<ApiResponse> GetSingleAsync(int id);

        Task<ApiResponse> AddAsync(T model);

        Task<ApiResponse> UpdateAsync(T model);

        Task<ApiResponse> DeleteAsync(int id);
    }
}

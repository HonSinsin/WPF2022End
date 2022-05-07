using Arch.EntityFrameworkCore.UnitOfWork;
using System;
using System.Threading.Tasks;
using WPFTodo.Api.Context;

namespace WPFTodo.Api.Serivce
{
    /// <summary>
    /// 待办事件实现
    /// </summary>
    public class ToDoService : IToDoService
    {
        private readonly IUnitOfWork work;

        public ToDoService(IUnitOfWork unitOfWork)
        {
            this.work = unitOfWork;
        }

        public async Task<ApiResponse> AddAsync(ToDo model)
        {
            try
            {
                await work.GetRepository<ToDo>().InsertAsync(model);
                if (await work.SaveChangesAsync() > 0)
                    return new ApiResponse(true, model);
                return new ApiResponse("数据添加失败");
            }
            catch (System.Exception ex)
            {
                return new ApiResponse(ex.Message);
            }
        }

        public async Task<ApiResponse> DeleteAsync(int id)
        {
            try
            {
                var repository = work.GetRepository<ToDo>();
                var todo = await repository.GetFirstOrDefaultAsync(predicate: x => x.Id.Equals(id));

                repository.Delete(todo);

                if (await work.SaveChangesAsync() > 0)
                    return new ApiResponse(true, "");
                return new ApiResponse("数据删除失败");
            }
            catch (System.Exception ex)
            {
                return new ApiResponse(ex.Message);
            }
        }

        public async Task<ApiResponse> GetAllAsync()
        {
            try
            {
                var repository = work.GetRepository<ToDo>();
                var todos = await repository.GetAllAsync();

                return new ApiResponse(true, todos);
            }
            catch (System.Exception ex)
            {
                return new ApiResponse(ex.Message);
            }
        }

        public async Task<ApiResponse> GetSingleAsync(int id)
        {
            try
            {
                var repository = work.GetRepository<ToDo>();
                var todo = await repository.GetFirstOrDefaultAsync(predicate: x => x.Id.Equals(id));

                repository.Delete(todo);

                if (await work.SaveChangesAsync() > 0)
                    return new ApiResponse(true, "");
                return new ApiResponse("数据查询失败");
            }
            catch (System.Exception ex)
            {
                return new ApiResponse(ex.Message);
            }
        }

        public async Task<ApiResponse> UpdateAsync(ToDo model)
        {
            try
            {
                var repository = work.GetRepository<ToDo>();
                var todo = await repository.GetFirstOrDefaultAsync(predicate: x => x.Id.Equals(model.Id));

                todo.Title = model.Title;
                todo.Context = model.Context;
                todo.UpdateTime = DateTime.Now;
                //todo.Status = model.Status;

                repository.Update(todo);

                if (await work.SaveChangesAsync() > 0)
                    return new ApiResponse(true, todo);

                return new ApiResponse("数据更新异常");
            }
            catch (System.Exception ex)
            {
                return new ApiResponse(ex.Message);
            }
        }
    }
}

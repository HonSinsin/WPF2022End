using Arch.EntityFrameworkCore.UnitOfWork;
using AutoMapper;
using System;
using System.Threading.Tasks;
using WPFTodo.Api.Context;
using WPFToDo.Shared.Dtos;

namespace WPFTodo.Api.Serivce
{
    /// <summary>
    /// 待办事件实现
    /// </summary>
    public class ToDoService : IToDoService
    {
        private readonly IUnitOfWork work;
        private readonly IMapper mapper;

        public ToDoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.work = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<ApiResponse> AddAsync(ToDoDto model)
        {
            try
            {
                var todo = mapper.Map<ToDo>(model);
                await work.GetRepository<ToDo>().InsertAsync(todo);
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

        public async Task<ApiResponse> UpdateAsync(ToDoDto model)
        {
            try
            {
                var dbtood = mapper.Map<ToDo>(model);
                var repository = work.GetRepository<ToDo>();
                var todo = await repository.GetFirstOrDefaultAsync(predicate: x => x.Id.Equals(dbtood.Id));

                todo.Title = dbtood.Title;
                todo.Context = dbtood.Context;
                todo.UpdateTime = DateTime.Now;
                //todo.Status = dbtood.Status;

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

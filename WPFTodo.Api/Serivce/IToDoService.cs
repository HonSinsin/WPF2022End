using Arch.EntityFrameworkCore.UnitOfWork;
using System;
using System.Threading.Tasks;
using WPFTodo.Api.Context;
using WPFToDo.Shared.Dtos;

namespace WPFTodo.Api.Serivce
{
    /// <summary>
    /// todo 事件
    /// </summary>
    public interface IToDoService : IBaseService<ToDoDto>
    {

    }
}

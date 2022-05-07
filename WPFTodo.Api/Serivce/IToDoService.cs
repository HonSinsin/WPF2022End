using Arch.EntityFrameworkCore.UnitOfWork;
using System;
using System.Threading.Tasks;
using WPFTodo.Api.Context;

namespace WPFTodo.Api.Serivce
{
    /// <summary>
    /// todo 事件
    /// </summary>
    public interface IToDoService : IBaseService<ToDo>
    {

    }
}

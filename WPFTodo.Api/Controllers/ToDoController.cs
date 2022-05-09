using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WPFTodo.Api.Context;
using WPFTodo.Api.Serivce;
using WPFToDo.Shared.Dtos;

namespace WPFTodo.Api.Controllers
{
    /// <summary>
    /// 待办事项控制器
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ToDoController : ControllerBase
    {
        public IToDoService serivce;
        public ToDoController(IToDoService serivce)
        {
            this.serivce = serivce;
        }

        [HttpGet]
        public async Task<ApiResponse> Get(int id) => await serivce.GetSingleAsync(id);

        [HttpGet]
        public async Task<ApiResponse> GetAll() => await serivce.GetAllAsync();

        [HttpPost]
        public async Task<ApiResponse> Add([FromBody] ToDoDto model) => await serivce.AddAsync(model);

        [HttpPost]
        public async Task<ApiResponse> Update([FromBody] ToDoDto model) => await serivce.UpdateAsync(model);

        [HttpDelete]
        public async Task<ApiResponse> Delete(int id) => await serivce.DeleteAsync(id);
    }
}

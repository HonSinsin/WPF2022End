using AutoMapper;
using WPFTodo.Api.Context;
using WPFToDo.Shared.Dtos;

namespace WPFTodo.Api.Extensions
{
    public class AutoMapperProFile : MapperConfigurationExpression
    {
        public AutoMapperProFile()
        {
            CreateMap<ToDo, ToDoDto>().ReverseMap();
        }
    }
}

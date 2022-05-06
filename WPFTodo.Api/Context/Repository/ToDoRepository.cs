using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WPFTodo.Api.Context.Repository
{

    public class ToDoRepository : Repository<ToDo>, IRepository<ToDo>
    {
        public ToDoRepository(WPFToDoContext dbContext) : base(dbContext)
        {

        }
    }
}

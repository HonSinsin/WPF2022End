using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using WPFTodo.Api.Context;

namespace WPFTodo.Api
{
    public class UserRepository : Repository<User>, IRepository<User>
    {
        public UserRepository(WPFToDoContext dbContext) : base(dbContext)
        {
        }
    }
}

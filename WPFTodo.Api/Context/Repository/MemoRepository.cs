using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace WPFTodo.Api.Context.Repository
{
    public class MemoRepository : Repository<Memo>, IRepository<Memo>
    {
        public MemoRepository(WPFToDoContext dbContext) : base(dbContext)
        {
        }
    }
}

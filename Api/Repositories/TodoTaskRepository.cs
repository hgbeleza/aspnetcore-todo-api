using Api.Data;
using Api.Entities;
using Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class TodoTaskRepository : ITodoTaskRepository
    {
        private readonly DatabaseConnectionContext _context;

        public TodoTaskRepository(DatabaseConnectionContext context)
        {
            _context = context;
        }

        public async Task<TodoTask> GetItemById(int id)
        {
            var result = await _context.TodoTasks.SingleOrDefaultAsync(t => t.Id == id);
            return result;
        }

        public async Task<IEnumerable<TodoTask>> GetItems()
        {
            var result = await _context.TodoTasks.ToListAsync();
            return result;
        }
    }
}

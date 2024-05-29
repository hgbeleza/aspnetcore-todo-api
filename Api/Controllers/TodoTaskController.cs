using Api.Entities;
using Api.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoTaskController : ControllerBase
    {
        private readonly ITodoTaskRepository _todoTaskRepository;

        public TodoTaskController(ITodoTaskRepository todoTaskRepository)
        {
            _todoTaskRepository = todoTaskRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoTask>>> GetItems()
        {
            var result = await _todoTaskRepository.GetItems();
            return Ok(result);
        }
    }
}

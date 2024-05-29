using Api.Data.Dtos;
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

        [HttpPost]
        public async Task<ActionResult<TodoTask>> AddItem(TaskToAddDto taskToAddDto)
        {
            var newTask = await _todoTaskRepository.AddItem(taskToAddDto);
            return newTask;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoTask>>> GetItems()
        {
            var result = await _todoTaskRepository.GetItems();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<TodoTask>> GetItemById(int id)
        {
            var result = await _todoTaskRepository.GetItemById(id);
            return result;
        }
    }
}

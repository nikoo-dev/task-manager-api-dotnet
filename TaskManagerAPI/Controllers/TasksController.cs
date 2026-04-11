using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;

namespace TaskManagerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        public static List<TaskItem> tasks = new List<TaskItem>();
        public static int nextId = 1;

        [HttpGet]
        public ActionResult<List<TaskItem>> GetAll()
        {
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public ActionResult<TaskItem> GetById(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
                return NotFound();
            return Ok(task);
        }

        [HttpPost]
        public ActionResult<TaskItem> Create(TaskItem task)
        {
            task.Id = nextId++;
            task.CreatedAt = DateTime.Now;
            tasks.Add(task);
            return CreatedAtAction(nameof(GetById), new { id = task.Id }, task);
        }
        [HttpPut("{id}")]
        public ActionResult Update(int id, TaskItem updated)
        {
         var task = tasks.FirstOrDefault(t => t.Id == id);
         if (task == null) return NotFound();
         task.Title = updated.Title;
         task.Description = updated.Description;   
         task.IsCompleted = updated.IsCompleted;
         return NoContent();

        
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task == null) return NotFound();
            tasks.Remove(task);
            return NoContent();
        }



    }








}

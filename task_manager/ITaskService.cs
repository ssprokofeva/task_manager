using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_manager
{
    public interface ITaskService
    {
        Task<List<Task>> GetAllTasksAsync();
        Task AddTaskAsync(Task task);
        Task UpdateTaskAsync(Task task);
        Task DeleteTaskAsync(Task task);
    }
}

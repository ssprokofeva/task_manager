using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_manager
{
    public interface ITaskRepository
    {
        Task<List<Task>> GetAllAsync();
        Task AddAsync(Task task);
        Task UpdateAsync(Task task);
        Task DeleteAsync(Task task);
    }
}

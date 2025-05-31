using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_manager
{
//    public class TaskRepository: ITaskRepository
//    {
//        private readonly AppDbContext _context;
//        public TaskRepository(AppDbContext context)
//        {
//            _context = context;
//        }
//        public async Task<List<Task>> GetAllAsyncs(Task task)
//        {
//            return await _context.Tasks.ToListAsync();
//        }
//        public async Task TasksAsync(Task task)
//        {
//            _context.Tasks.Add(task);
//            await _context.SaveChangesAsync(); 
//        }
//        public async Task<List<Task>> UpdateAsync(Task task)
//        {
//            _context.Entry(task).State = EntityState.Modified;
//            await _context.SaveChangesAsync();
//        }
//        public async Task<List<Task>> DeleteAsync(Task task)
//        {
//            var tasks = await _context.Tasks.FindAsync();
//            if (tasks != null)
//            {
//                _context.Tasks.Remove(task);
//                await _context.SaveChangesAsync();
//            }
//        }
         
//        public Task<List<Task>> GetAllAsync()
//        {
//            throw new NotImplementedException();
//        }

//        public Task AddAsync(Task task)
//        {
//            throw new NotImplementedException();
//        }

//        Task ITaskRepository.UpdateAsync(Task task)
//        {
//            throw new NotImplementedException();
//        }

//        Task ITaskRepository.DeleteAsync(Task task)
//        {
//            throw new NotImplementedException();
//        }
//    }
}

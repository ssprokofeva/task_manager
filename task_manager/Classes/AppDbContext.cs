using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_manager
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() : base("name=TaskManagerConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AppDbContext>());
        }

        public DbSet<Task> Tasks { get; set; }
    }

}


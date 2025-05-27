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
        public AppDbContext() : base(" name = TaskManagerConnection");
        public DbSet<Task> Tasks { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
            .Property(t => t.title())
            .IsRequired()
            .HasMaxLength(255);
            base.OnModelCreating(modelBuilder);
        }

    }
}

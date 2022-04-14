using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ToDoListApp_Project.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ModelEntity")
        {
        }

        public virtual DbSet<ToDo> ToDos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>()
                .Property(e => e.Title)
                .IsUnicode(false);
        }
    }
}

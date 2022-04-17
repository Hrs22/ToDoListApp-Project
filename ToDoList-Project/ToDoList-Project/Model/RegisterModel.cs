using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ToDoList_Project.Model
{
    public partial class RegisterModel : DbContext
    {
        public RegisterModel()
            : base("name=RegisterModel")
        {
        }

        public virtual DbSet<RegisterTable> RegisterTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegisterTable>()
                .Property(r => r.username)
                .IsUnicode(true);
        }
    }
}

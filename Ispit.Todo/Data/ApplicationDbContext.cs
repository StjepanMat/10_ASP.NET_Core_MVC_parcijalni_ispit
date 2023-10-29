using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ispit.Todo.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ispit.Todo.Data
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(100)]
        public string? FirstName { get; set; }

        [StringLength(100)]
        public string? LastName { get; set; }

        [ForeignKey("UserId")]
        public virtual ICollection<TodoList> TodoLists { get; set; }

    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ispit.Todo.Models.Task> Tasks { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }
    }
}
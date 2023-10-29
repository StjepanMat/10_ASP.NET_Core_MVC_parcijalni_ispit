using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Ispit.Todo.Models
{
    public class TodoList
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "List should have a name.")]
        [StringLength(100, MinimumLength = 2)]
        public string Title { get; set; }

        [Required(ErrorMessage = "List description is required.")]
        [StringLength(500, MinimumLength = 2)]
        public string Description { get; set; }

        public string UserId { get; set; }

        [ForeignKey("TodoListId")]
        public virtual ICollection<Task> Tasks { get; set; }
    }
}

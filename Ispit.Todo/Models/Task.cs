using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ispit.Todo.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        public int TodoListId { get; set; }

        [Required(ErrorMessage ="Task description is required")]
        [StringLength(200, MinimumLength = 2)]
        public string SingleTask { get; set; }

        public bool Completed { get; set; } = false;


    }
}
using System.ComponentModel.DataAnnotations;

namespace BoolkyBookWeb.Models
{
    public class Category
    {
        public static string table = "Categories";

        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;

        /*[Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;*/

    }
}

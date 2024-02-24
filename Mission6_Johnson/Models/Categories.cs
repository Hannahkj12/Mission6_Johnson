using System.ComponentModel.DataAnnotations;
namespace Mission6_Johnson.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}

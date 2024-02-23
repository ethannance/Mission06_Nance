using System.ComponentModel.DataAnnotations;

namespace Mission06_Nance.Models
{
    public class CategoryCategory
    {
        [Key]
        public int CategoryId { get; set; }
        public string? Category { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Nance.Models
{
    [Table("Movies")]
    public class Application
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; } 
        public CategoryCategory? Category { get; set; }

        [Required(ErrorMessage = "Please enter a movie title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1888,9999)]
        public string Year { get; set; }
        public string? Director { get; set; }
        
        public string? Rating { get; set; } //Add ? to make nullable

        [Required(ErrorMessage = "Please enter edited status.")]
        public bool Edited { get; set; } 
        
        public string? LentTo { get; set; } 

        [Required(ErrorMessage = "Please enter copied to plex status.")]
        public bool CopiedToPlex { get; set; }

        [StringLength(25, ErrorMessage = "The notes cannot be more than 25 characters long.")]
        public string? Notes { get; set; }
        
    }
}

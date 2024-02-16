using System.ComponentModel.DataAnnotations;

namespace Mission06_Nance.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int ApplicationID { get; set; }
        [Required]
        public string Main_Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year_Released { get; set; }
        [Required]
        public string Primary_Director { get; set; }
        [Required]
        public string Rating { get; set; }
        //Add ? to make nullable
        public bool? Edited { get; set; }

        public string? LentTo { get; set; }


        [StringLength(25, ErrorMessage = "The notes cannot be more than 25 characters long.")]
        public string? Notes { get; set; }
        
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_Takaku.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        [Required(ErrorMessage = "You need to input Title")]
        public string Title { get; set; }
        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "You need to type valid year (After 1888)")]
        public int Year {  get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required(ErrorMessage ="You need to select Edited 'Yes' or 'no'")]
        public bool?  Edited { get; set; }
        public string? LentTo { get; set; }
        [Required(ErrorMessage ="You need to select Copied To Plex 'Yes' or 'no'")]
        public bool? CopiedToPlex { get; set; }
        [MaxLength(25)]
        public string? Notes {  get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Create Movie class. Show message if there is invalid values
namespace Mission6_Takaku.Models
{
    public class Movie
    {
        //MovieId is primary key
        [Key]
        [Required]
        public int MovieId { get; set; }

        //CategoryId is foreignkey
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; } = 0;

        //get value from category table using Category in Movie.cs
        public Category? Category { get; set; }

        [Required(ErrorMessage = "You need to input Title")]
        public string Title { get; set; }

        //Year should be later than 1888
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

        //Max Length for notes is 25 characters
        [MaxLength(25)]
        public string? Notes {  get; set; }
    }
}

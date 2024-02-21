using System.ComponentModel.DataAnnotations;

//Create a class category, and both CategoryId and CategoryName are not null.
namespace Mission6_Takaku.Models
{
    public class Category
    {
        //set as a key
        [Key]
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName {  get; set; }
    }
}

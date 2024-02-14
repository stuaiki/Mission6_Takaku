using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Mission6_Takaku.Models
{
    //These are getter and setter setting
    public class Collection
    {
        //Set key required for collectionID. CollectionID is primary key.
        [Key]
        [Required]
        public int CollectionID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director {  get; set; }
        [Required]
        public string Rating { get; set; }
        public bool? Edited { get; set; }// nullable value
        public string? LentTo { get; set; }//nullable value

        [MaxLength(25)]
        public string? Note {  get; set; }//nullable value
    }
}

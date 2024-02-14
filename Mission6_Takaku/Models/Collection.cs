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
        public string Category { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director {  get; set; }
        public string Rating { get; set; }
        public bool? Edited { get; set; }// nullable value
        public string? LentTo { get; set; }//nullable value

        [MaxLength(25)]
        public string? Note {  get; set; }//nullable value
    }
}

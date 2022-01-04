using System.ComponentModel.DataAnnotations;

namespace BookRazor.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }

        public string author { get; set; }

    }
}

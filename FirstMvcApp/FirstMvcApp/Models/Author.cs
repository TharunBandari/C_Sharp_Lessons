using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirstMvcApp.Models
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorID { set; get; }
        public String AuthorName { set; get; } = String.Empty;



        public int NoOfBooksPublished { set; get; }
        public int AuthorDateOfBirth { set; get; }



        public String RoyalityCompany { set; get; } = String.Empty;
    }
}

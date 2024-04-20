using System.ComponentModel.DataAnnotations;

namespace Web2_1604.Model
{
    public class Book_Author
    {
        [Key]
       public int Id { get; set; }
       public int BookId { get; set; }
       public Books Books { get; set; }
        [Key]
       public int AuthorId { get; set; }
       public Authors Author { get; set; }
    }
    public enum GenreType
    {
        Fiction,
        NonFiction,
        Mystery,
        Thriller,
        Romance,
        ScienceFiction,
        Fantasy,
        Biography,
        History,
        Poetry,
        Other
    }
}

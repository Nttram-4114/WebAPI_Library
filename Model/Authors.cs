using System.ComponentModel.DataAnnotations;

namespace Web2_1604.Model
{
    public class Authors
    {
       
        [Key]
        public int Id { get; set; }
        public string? FullName { get; set; }
        public ICollection<Book_Author> Book_Authors { get; set; }
    }

}

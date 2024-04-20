using System.ComponentModel.DataAnnotations;

namespace Web2_1604.Model
{
    public class Publishers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
      
    }
}

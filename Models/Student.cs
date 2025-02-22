using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
    }
}

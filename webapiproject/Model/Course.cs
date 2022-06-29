using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapiproject.Model
{
    [Table("course")]
    public class Course
    {

        

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fees { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace MVCGrund.Models
{

#nullable disable
    public class Employee
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Namn")]
        [StringLength(30)]
        public string Name { get; set; }

        [Range(5, 200)]
        public int Salary { get; set; }

        public string Department { get; set; }



    }
}

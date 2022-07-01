using System.ComponentModel.DataAnnotations;

namespace MVCGrund.Models.ViewModel
{
    public class EmployeeIndexViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Namn")]
        public string Name { get; set; }

        [Display(Name = "Avdelning")]
        public string Department { get; set; }
    }
}

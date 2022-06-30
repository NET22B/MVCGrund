namespace MVCGrund.Models
{
    public class Employee
    {
        //Detta är en entitet
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public string? Department { get; set; }


        public Employee()
        {

        }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}

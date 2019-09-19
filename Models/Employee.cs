
using System;

namespace intro2MVC.Models
{
    [Serializable]
    public class Employee
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public int Age { get; set; }
        public string NationalInsuranceNmuber { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public double MonthlySalary { get; set; }


    }
}
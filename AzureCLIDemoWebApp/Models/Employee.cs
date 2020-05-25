using System;

namespace AzureCLIDemoWebApp.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public string Extension { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
    }
}

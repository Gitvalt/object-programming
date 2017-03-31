using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2.Model
{
    public class Employee
    {
        public string ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string JobTitle { get; set; }
        public EmployeeImage Image { get; set; }
        public string Fullname
        {
            get
            {
                return Lastname + " " + Firstname;
            }
        }
    }

    /// <summary>
    /// This class holds employee view model data.
    /// </summary>
    public class EmployeeViewModel
    {
        
        private ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public EmployeeViewModel()
        {
            // generate dummy data if needed
        }
    }
}

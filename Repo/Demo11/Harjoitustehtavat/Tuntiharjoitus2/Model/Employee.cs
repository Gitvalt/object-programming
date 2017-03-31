using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Tuntiharjoitus2.Model
{
    public class Employee : INotifyPropertyChanged
    {
        public string ID { get; set; }

        private string firstname { get; set; }
        public string Firstname
        {
            get { return firstname; }
            set {
                firstname = value;
                Fullname = firstname + lastname;
                RaisePropertyChanged();
            }

        }
        private string lastname;
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
                Fullname = firstname + lastname;
                RaisePropertyChanged();
            }
        }

        private string jobTitle;
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
                RaisePropertyChanged();
            }
        }


        private EmployeeImage image;
        public EmployeeImage Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                RaisePropertyChanged();
            }
        }   
    


        private string fullname;
        public string Fullname
        {
            get
            {
                return Lastname + " " + Firstname;
            }
            set
            {
                fullname = value;
                RaisePropertyChanged();
            }
        }
    

    public Employee(string a, string b, string c, EmployeeImage z)
        {
            Firstname = a;
            Lastname = b;
            JobTitle = c;
            Image = z;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }





    public class EmployeeViewModel
    {
        /*
        private List<Employee> employees = new List<Employee>();
        public List<Employee> Employees { get { return employees; } }
        */
       private ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }
        

        public EmployeeViewModel()
        {
            // generate some dummy data for testing purposes
      
        }

        public void AddEmployee(string a, string b, string c, EmployeeImage z)
        {
            employees.Add(new Employee(a, b, c, z));
        }

        public void RemoveEmployee(Employee employee)
        {

            Employees.Remove(employee);
        }
    }

}

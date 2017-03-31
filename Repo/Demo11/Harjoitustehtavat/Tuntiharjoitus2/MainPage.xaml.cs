using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Tuntiharjoitus2.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tuntiharjoitus2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>



    public sealed partial class MainPage : Page
    {


        public EmployeeViewModel ViewModel { get; set; }
        public EmployeeImageViewModel ImageViewModel { get; set; }


        public MainPage()
        {
            this.InitializeComponent();
            this.ViewModel = new EmployeeViewModel();
            this.ImageViewModel = new EmployeeImageViewModel();        

        }

        private void NewEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            // add a new employee
            EmployeeImage employeeImage = (EmployeeImage)ImageComboBox.SelectedValue;
            ViewModel.AddEmployee(FirstnameTextBox.Text, LastnameTextBox.Text, JobTitleTextBox.Text, employeeImage);

            // empty UI fields
            FirstnameTextBox.Text = "";
            LastnameTextBox.Text = "";
            JobTitleTextBox.Text = "";
            ImageComboBox.SelectedIndex = -1;

            // select firstname
            FirstnameTextBox.Focus(FocusState.Programmatic);
        }

        private void EmployeesGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            // selected employee
            Employee employee = (Employee)e.ClickedItem;
            // update form data
            FirstnameTextBox.Text = employee.Firstname;
            LastnameTextBox.Text = employee.Lastname;
            JobTitleTextBox.Text = employee.JobTitle;
            ImageComboBox.SelectedValue = employee.Image;
        }



        private void ModifyEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            // get selected employee from GridView
            Employee employee = (Employee)EmployeesGridView.SelectedItem;
            // update selected employee's data from form
            employee.Firstname = FirstnameTextBox.Text;
            employee.Lastname = LastnameTextBox.Text;
            employee.JobTitle = JobTitleTextBox.Text;
            EmployeeImage employeeImage = (EmployeeImage)ImageComboBox.SelectedItem;
            employee.Image = employeeImage;
        }
        private void DeleteEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            // get selected employee from GridView
            Employee employee = (Employee)EmployeesGridView.SelectedItem;
            // remove from collection
            ViewModel.RemoveEmployee(employee);
        }

        private void EmployeesGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

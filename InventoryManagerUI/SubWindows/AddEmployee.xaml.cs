using IMClassLibrary;
using IMClassLibrary.Models;
using InventoryManagerUI.MainWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InventoryManagerUI.SubWindows
{
    /// <summary>
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        // The stored inventory instace to be used to refresh the data grid 
        Employees employeesInstance = new Employees();

        public AddEmployee()
        {
            InitializeComponent();

        }

        /// <summary>
        /// The way to only accept numbers in the field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quantity_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


        public void RefreshEmployeesList()
        {
            employeesInstance.RefreshList();
        }

        public void AddEmployeeInstance(Employees employees)
        {
            employeesInstance = employees;
        }

        private void saveProductButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeModel emp = new EmployeeModel();

            // TODO - Try catch
            emp.FirstName = firtNameTextBox.Text;
            emp.LastName = lastNameTextBox.Text;
            emp.Birthday = birthdayTextBox.Text;
            emp.JobRole = jobRoleTextBox.Text; //TODO 
            emp.Salary = float.Parse( salaryNameTextBox.Text);
            emp.ContactNumber = int.Parse( contactNumberTextBox.Text);
            emp.Adress = adressTextBox.Text;

            SqliteDataAccess.SaveEmployee(emp);

            RefreshEmployeesList();

            this.Close();
        }
    }
}

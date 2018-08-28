using IMClassLibrary;
using IMClassLibrary.Models;
using InventoryManagerUI.SubWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InventoryManagerUI.MainWindows
{
    /// <summary>
    /// Interaction logic for Employees.xaml
    /// </summary>
    public partial class Employees : Window
    {
        public List<EmployeeModel> employees = new List<EmployeeModel>();

        public Employees()
        {
            InitializeComponent();

            employees = SqliteDataAccess.LoadEmployees();
            employeesListDataGrid.ItemsSource = employees;
        }

        public void RefreshList()
        {
            employees = SqliteDataAccess.LoadEmployees();
            employeesListDataGrid.ItemsSource = null;
            employeesListDataGrid.ItemsSource = employees;
        }

        private void refrehEmployeesButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshList();
        }

        private void removeEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            SqliteDataAccess.RemoveEmployee((EmployeeModel)employeesListDataGrid.SelectedItem);
            RefreshList();
        }

        private void addEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee add = new AddEmployee();
            add.Owner = this;
            add.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            add.Show();
            add.AddEmployeeInstance(this);
        }
    }
}

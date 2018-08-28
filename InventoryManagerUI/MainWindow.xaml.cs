using IMClassLibrary;
using IMClassLibrary.DataAccess;
using InventoryManagerUI.MainWindows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InventoryManagerUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(string companyType)
        {
            InitializeComponent();

            // Function that displays the right data depending of the user company data
            LoadCompanyData(CompanyVariables.CurrentLoggedInUserID, companyType);
        }


        public void LoadCompanyData(int currentUserID, string companyType)
        {
            if (companyType == "Default")
            {
                foreach (var i in SqliteDataAccess.LoadCompany(currentUserID))
                {
                    companyName.Text = "Default";

                    IMClassLibrary.Helper.HelperClass.WriteCurrentLoggedCompanyToVariables(i);
                }
            }
            if (companyType == "SoleTrader")
            {
                foreach (var i in SqliteDataAccess.LoadCompany(currentUserID))
                {
                    companyName.Text = i.CompanyName;

                    IMClassLibrary.Helper.HelperClass.WriteCurrentLoggedCompanyToVariables(i);
                }
            }

            if (companyType == "PersonalFinance")
            {
                foreach (var t in SqliteDataAccess.LoadPersonalFinances())
                {
                    if (t.LinkedUserID == currentUserID)
                    {
                        companyName.Text = t.OwnerName;

                        IMClassLibrary.Helper.HelperClass.WriteCurrentLoggedPersonalFincanceToVariables(t);
                    }
                    
                }
            }

            if (companyType == "RetailStore")
            {
                foreach (var i in SqliteDataAccess.LoadCompany(currentUserID))
                {
                    companyName.Text = i.CompanyName;

                    IMClassLibrary.Helper.HelperClass.WriteCurrentLoggedCompanyToVariables(i);
                }
            }

            if (companyType == "Warehouse")
            {
                foreach (var i in SqliteDataAccess.LoadCompany(currentUserID))
                {
                    companyName.Text = i.CompanyName;

                    IMClassLibrary.Helper.HelperClass.WriteCurrentLoggedCompanyToVariables(i);
                }
            }


        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Activity homeWindow = new Activity();
            homeWindow.Owner = this;
            homeWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            homeWindow.Show();
        }

        private void InventoryButton_Click(object sender, RoutedEventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Owner = this;
            inv.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            inv.Show();
        }

        private void EmployeesButton_Click(object sender, RoutedEventArgs e)
        {
            Employees emp = new Employees();
            emp.Owner = this;
            emp.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            emp.Show();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_GotMouseCapture(object sender, MouseEventArgs e)
        {
           
        }

    }
}

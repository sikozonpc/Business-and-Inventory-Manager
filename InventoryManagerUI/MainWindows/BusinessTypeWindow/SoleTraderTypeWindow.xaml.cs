using IMClassLibrary;
using IMClassLibrary.DataAccess;
using IMClassLibrary.Models;
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

namespace InventoryManagerUI.MainWindows.BusinessTypeWindow
{
    /// <summary>
    /// Interaction logic for SoleTraderTypeWindow.xaml
    /// </summary>
    public partial class SoleTraderTypeWindow : Window
    {
        public List<String> Currency = new List<string>();
        UserModel currentUser = new UserModel();

        public SoleTraderTypeWindow(UserModel user)
        {
            currentUser = user;

            InitializeComponent();

            // Populate the currency combobox
            Currency.Add("$");
            Currency.Add("€");
            Currency.Add("£");

            currencyComboBox.ItemsSource = Currency;
        }

        private void CreateCompanyModel()
        {
            CompanyModel company = new CompanyModel();

            company.BusinessType = "SoleTrader";
            company.CompanyName = companyNameTextBox.Text;
            company.CurrentMonthBudget = companyBudgetTextBox.Text;
            company.CurrentMonthSpent = companyCurrentSpendingTextBox.Text;
            company.Currency = (string)currencyComboBox.SelectedItem;
            company.LinkedUserID = CompanyVariables.CurrentLoggedInUserID;
            company.TotalSpending += double.Parse(company.CurrentMonthSpent);

            SqliteDataAccess.UpdateCompanyType(currentUser, "SoleTrader");

            SqliteDataAccess.SaveNewCompany(company);
            IMClassLibrary.Helper.HelperClass.WriteCurrentLoggedCompanyToVariables(company);
        }


        private void StartCompanyButton_Click(object sender, RoutedEventArgs e)
        {
            int readyToContinue = 5;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#F29705");
            

            // Cheking if statements for invalid fields 
            if (companyBudgetTextBox.Text == "")
            {
                MessageBox.Show("Invalid Budget.", "Invalid Data", MessageBoxButton.OK, MessageBoxImage.Error);
                brush = (Brush)converter.ConvertFromString("#F29705");
                companyBudget.Foreground = brush; 
                readyToContinue -= 1;
            }
            else
            {
                CompanyVariables.CurrentMonthBudget = companyBudgetTextBox.Text;
                brush = (Brush)converter.ConvertFromString("#ffffff");
                companyBudget.Foreground = brush;
            }


            if (companyNameTextBox.Text == "")
            {
                MessageBox.Show("Invalid Company Name.", "Invalid Data", MessageBoxButton.OK, MessageBoxImage.Error);
                brush = (Brush)converter.ConvertFromString("#F29705");
                companyName.Foreground = brush;
                readyToContinue -= 1;
            }
            else
            {
                CompanyVariables.CompanyName = companyNameTextBox.Text;
                brush = (Brush)converter.ConvertFromString("#ffffff");
                companyName.Foreground = brush;
            }

            if (currencyComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a Currency.", "Invalid Data", MessageBoxButton.OK, MessageBoxImage.Error);
                readyToContinue -= 1;
            }
            else
            {
                CompanyVariables.Currency = (String)currencyComboBox.SelectedItem;

            }

            if (companyCurrentSpendingTextBox.Text == "")
            {
                MessageBox.Show("Invalid Spendings.", "Invalid Data", MessageBoxButton.OK, MessageBoxImage.Error);
                brush = (Brush)converter.ConvertFromString("#F29705");
                companySpendings.Foreground = brush;
                readyToContinue -= 1;
            }
            else
            {
                CompanyVariables.CurrentMonthSpent = companyCurrentSpendingTextBox.Text;
                brush = (Brush)converter.ConvertFromString("#ffffff");
                companySpendings.Foreground = brush;
            }

            // By having this temp var the app assures that it won't start any mroe funtions before the data is all complete
            if (readyToContinue == 5)
            {
                // Database communication
                CreateCompanyModel();


                // Starts the dashboard
                MainWindow window = new MainWindow("SoleTrader");
                window.Owner = this;
                window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                window.Show();

                // Sets the owner to the new window so that the user can close the StarterWindow and 
                // the program not close.
                window.Owner = null;
                this.Owner = window;
                this.Close();
            }
           
        }
    }
}

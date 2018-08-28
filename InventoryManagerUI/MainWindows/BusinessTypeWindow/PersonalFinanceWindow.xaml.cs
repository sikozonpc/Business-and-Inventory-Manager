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
    /// Interaction logic for PersonalFinanceWindow.xaml
    /// </summary>
    public partial class PersonalFinanceWindow : Window
    {
        public List<String> Currency = new List<string>();
        UserModel currentUser = new UserModel();


        public PersonalFinanceWindow(UserModel user)
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
            PersonalFinanceModel owner = new PersonalFinanceModel();

            owner.OwnerName = ownerNameTextBox.Text;
            owner.TotalIncome = double.Parse( ownerTotalIncome.Text );
            owner.Expenses = double.Parse( expensesTextBox.Text );
            owner.Currency = (string)currencyComboBox.SelectedItem;
            owner.LinkedUserID = CompanyVariables.CurrentLoggedInUserID;
            owner.HouseRents = double.Parse( houseRentsTextBox.Text );
            owner.Debts = double.Parse( debtsTextBox.Text );
            owner.TotalSpending += double.Parse(owner.CurrentMonthSpent);

            SqliteDataAccess.UpdateCompanyType(currentUser, "PersonalFinance");

            SqliteDataAccess.SaveNewPersonalFincance(owner);
            IMClassLibrary.Helper.HelperClass.WriteCurrentLoggedPersonalFincanceToVariables(owner);
        }

        private void StartCompanyButton_Click(object sender, RoutedEventArgs e)
        {
            CompanyVariables.CompanyName = ownerNameTextBox.Text;
            CompanyVariables.Currency = (String)currencyComboBox.SelectedItem;

            // Database communication
            CreateCompanyModel();

            // Starts the dashboard
            MainWindow window = new MainWindow("PersonalFinance");
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

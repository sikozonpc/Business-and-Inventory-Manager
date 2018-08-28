using IMClassLibrary;
using IMClassLibrary.DataAccess;
using IMClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace InventoryManagerUI.MainWindows.ActivityPages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        private string currentYearAndMonth;

        private double progressBarWidth = 400;

        public Home()
        {
            InitializeComponent();

            // Sets the current month (remove cultureinfo if you want the text tranlated to your culture prefrence)
            currentYearAndMonth = DateTime.Now.ToString("Y", CultureInfo.InvariantCulture);
            yearGraph.currentYearText.Text = currentYearAndMonth;

            // Setting the textboxes with information
            totalmoneySpentValue.Text = CompanyVariables.TotalSpending.ToString() + " " + CompanyVariables.Currency; ;
            lastMonthMoneySpent.Text = CompanyVariables.LastMonthSpending.ToString() + " " + CompanyVariables.Currency;
            currentSpentValue.Text = "( " + CompanyVariables.CurrentMonthSpent.ToString() + " " + CompanyVariables.Currency + " )";

            // Starts the budget Progress bar
            BugetBarStart();

            // Sets the year Graph values
            MonthMoneyModel monthSpending = new MonthMoneyModel(DateTime.Now.Year,
                 2000, 3000, 4000, 5000, 1000, 2000, 3000, 4000, 0, 0, 0, 0);

            MonthMoneyModel monthBudget = new MonthMoneyModel(DateTime.Now.Year,
                 3500, 4000, 5500, 6000, 7000, 4000, 6000, 6000, 0, 0, 0, 0);


            yearGraph.january.Height = (monthSpending.MonthValues[0] / monthBudget.MonthValues[0]) * 200;
            yearGraph.feb.Height = (monthSpending.MonthValues[1] / monthBudget.MonthValues[1]) * 200;
            yearGraph.march.Height = (monthSpending.MonthValues[2] / monthBudget.MonthValues[2]) * 200;
            yearGraph.may.Height = (monthSpending.MonthValues[3] / monthBudget.MonthValues[3]) * 200;
            yearGraph.april.Height = (monthSpending.MonthValues[4] / monthBudget.MonthValues[4]) * 200;
            yearGraph.june.Height = (monthSpending.MonthValues[5] / monthBudget.MonthValues[5]) * 200;
            yearGraph.july.Height = (monthSpending.MonthValues[6] / monthBudget.MonthValues[6]) * 200;
            yearGraph.august.Height = (monthSpending.MonthValues[7] / monthBudget.MonthValues[7]) * 200;
            yearGraph.september.Height = (monthSpending.MonthValues[8] / monthBudget.MonthValues[8]) * 200;
            yearGraph.october.Height = (monthSpending.MonthValues[9] / monthBudget.MonthValues[9]) * 200;
            yearGraph.november.Height = (monthSpending.MonthValues[10] / monthBudget.MonthValues[10]) * 200;
            yearGraph.december.Height = (monthSpending.MonthValues[11] / monthBudget.MonthValues[11]) * 200;
        }

        // Buget Progress bar
        private void BugetBarStart()
        {
            progressBudgetBar.Width = 0;
            budgetValue.Text = "( " + CompanyVariables.CurrentMonthBudget.ToString() + " " + CompanyVariables.Currency + " )"; // 100%

            try
            {
                progressBudgetBar.Width = (Double.Parse( CompanyVariables.CurrentMonthSpent) / Double.Parse(CompanyVariables.CurrentMonthBudget)) * progressBarWidth; // drawn %
            }
            catch 
            {
                MessageBox.Show("Please make sure your company has a valid budget. If you haven't selected one yet, you can go to the settings" +
                    " and chose a budget", "Invalid Budget" , MessageBoxButton.OK , MessageBoxImage.Warning, MessageBoxResult.OK, MessageBoxOptions.ServiceNotification);
            }
            
        }

        private void MoneySpentHistory_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

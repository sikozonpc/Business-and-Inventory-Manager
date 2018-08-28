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
    /// Interaction logic for Spending.xaml
    /// </summary>
    public partial class Spending : Page
    {           
        List<ProductModel> previousPurchases { get; set; }

        public string Currency = CompanyVariables.Currency;

        private int lasYear = DateTime.Now.Year - 1;

        public Spending()
        {
            InitializeComponent();

            previousPurchases = new List<ProductModel>();

            // Sample product data models
            ProductModel model1 = new ProductModel() { Name = "Coca Cola", Quantity = 200, Id=12, Price="1.05", ReceiptDate="05-08-1999"};
            ProductModel model2= new ProductModel() { Name = "Chips", Quantity = 38, Id = 13, Price = "1.99", ReceiptDate = "25-08-1999" };
            ProductModel model3 = new ProductModel() { Name = "Water Bottle", Quantity = 1000, Id = 48, Price = "0.65", ReceiptDate = "23-02-1999" };

            previousPurchases.Add(model1);
            previousPurchases.Add(model2);
            previousPurchases.Add(model3);

            spendigsListView.ItemsSource = previousPurchases;

            // Setting data
            lastYearGraph.currentYearText.Text = lasYear.ToString();
            totalSpendings.Text = CompanyVariables.LastYearTotalSpending.ToString();
            currency.Text = CompanyVariables.Currency;

            MonthMoneyModel lastYearSpendings = new MonthMoneyModel(DateTime.Now.Year - 1,
               3000, 2000, 5000, 5000, 5000, 7000, 3000, 4000, 7000, 3000, 3000, 1000);

            MonthMoneyModel lastyearBudget = new MonthMoneyModel(DateTime.Now.Year - 1,
                7000, 7000, 7000, 5000, 5000, 7000, 5000, 12000, 12000, 5000, 8600, 5000);

            // Dispplaing the data to the graph 

            lastYearGraph.january.Height = (lastYearSpendings.MonthValues[0] / lastyearBudget.MonthValues[0]) * 200;
            lastYearGraph.feb.Height = (lastYearSpendings.MonthValues[1] / lastyearBudget.MonthValues[1]) * 200;
            lastYearGraph.march.Height = (lastYearSpendings.MonthValues[2] / lastyearBudget.MonthValues[2]) * 200;
            lastYearGraph.may.Height = (lastYearSpendings.MonthValues[3] / lastyearBudget.MonthValues[3]) * 200;
            lastYearGraph.april.Height = (lastYearSpendings.MonthValues[4] / lastyearBudget.MonthValues[4]) * 200;
            lastYearGraph.june.Height = (lastYearSpendings.MonthValues[5] / lastyearBudget.MonthValues[5]) * 200;
            lastYearGraph.july.Height = (lastYearSpendings.MonthValues[6] / lastyearBudget.MonthValues[6]) * 200;
            lastYearGraph.august.Height = (lastYearSpendings.MonthValues[7] / lastyearBudget.MonthValues[7]) * 200;
            lastYearGraph.september.Height = (lastYearSpendings.MonthValues[8] / lastyearBudget.MonthValues[8]) * 200;
            lastYearGraph.october.Height = (lastYearSpendings.MonthValues[9] / lastyearBudget.MonthValues[9]) * 200;
            lastYearGraph.november.Height = (lastYearSpendings.MonthValues[10] / lastyearBudget.MonthValues[10]) * 200;
            lastYearGraph.december.Height = (lastYearSpendings.MonthValues[11] / lastyearBudget.MonthValues[11]) * 200;
        }

        public void RefreshList()
        {
            //previousPurchases = SqliteDataAccess.LoadProducts();

        }
    }
}

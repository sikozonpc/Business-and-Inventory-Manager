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
    /// Interaction logic for Inventory.xaml
    /// </summary>
    public partial class Inventory : Window
    {
        List<ProductModel> products = new List<ProductModel>();

        public Inventory()
        {
            InitializeComponent();

            // Initializes the SQLite db data for the products
            products = SqliteDataAccess.LoadProducts();

            productsListDataGrid.ItemsSource = products;

        }

        public void RefreshList()
        {
            products = SqliteDataAccess.LoadProducts();
            productsListDataGrid.ItemsSource = null;
            productsListDataGrid.ItemsSource = products;
        }

        private void addProductButton_Click(object sender, RoutedEventArgs e)
        {
            AddProduct add = new AddProduct();
            add.Owner = this;
            add.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            add.Show();
            add.AddInventoryInstance(this);
        }

        private void removeProductButton_Click(object sender, RoutedEventArgs e)
        {
            SqliteDataAccess.RemoveProduct( (ProductModel)productsListDataGrid.SelectedItem );
            RefreshList();
        }

        private void refrehProductButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshList();
        }
    }
}

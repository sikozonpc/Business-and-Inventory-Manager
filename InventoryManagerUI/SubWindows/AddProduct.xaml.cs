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
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        // The stored inventory instace to be used to refresh the data grid 
        Inventory invInstance = new Inventory();

        public AddProduct()
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

        private void saveProductButton_Click(object sender, RoutedEventArgs e)
        {
            ProductModel p = new ProductModel();

            // TODO - Try catch
            p.Name = productNameTextBox.Text;
            p.Type = productTypeTextBox.Text;
            p.Quantity = int.Parse(productQuantityTextBox.Text);
            p.Price = productPriceTextBox.Text; //TODO 
            p.Provider = productProviderNameTextBox.Text;
            p.ReceiptDate = productReceiptDateTextBox.Text;
            p.Location = productLocationTextBox.Text;

            SqliteDataAccess.SaveProduct(p);

            RefreshInventoryList();

            this.Close();
        }
        

        public void RefreshInventoryList()
        {
            invInstance.RefreshList();
        }

        public void AddInventoryInstance(Inventory inv)
        {
            invInstance = inv;
        }
    }
}

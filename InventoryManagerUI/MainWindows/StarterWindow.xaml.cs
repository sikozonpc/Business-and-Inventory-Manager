using IMClassLibrary;
using IMClassLibrary.DataAccess;
using IMClassLibrary.Models;
using InventoryManagerUI.MainWindows.BusinessTypeWindow;
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

namespace InventoryManagerUI.MainWindows
{
    /// <summary>
    /// Interaction logic for StarterWindow.xaml
    /// </summary>
    public partial class StarterWindow : Window
    {
        private string companyType = "";
        UserModel currentUser = new UserModel();

        public StarterWindow(UserModel user)
        {
            currentUser = user;

            InitializeComponent();
        }


        public void ChangeButtonForegroundColor(int buttonNumber)
        {
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#F29705");

            switch (buttonNumber)
            {
                case 0:
                    brush = (Brush)converter.ConvertFromString("#F29705");
                    PersonalFinanceButton.Foreground = brush;

                    // Put other blank
                    brush = (Brush)converter.ConvertFromString("#ffffff");
                    RetailStoreButton.Foreground = brush;
                    SoleTraderTypeButton.Foreground = brush;
                    WarehouseStoreButton.Foreground = brush;

                    break;
                case 1:
                    brush = (Brush)converter.ConvertFromString("#F29705");
                    WarehouseStoreButton.Foreground = brush;

                    // Put other blank
                    brush = (Brush)converter.ConvertFromString("#ffffff");
                    RetailStoreButton.Foreground = brush;
                    SoleTraderTypeButton.Foreground = brush;
                    PersonalFinanceButton.Foreground = brush;
                    break;
                case 2:

                    brush = (Brush)converter.ConvertFromString("#F29705");
                    RetailStoreButton.Foreground = brush;

                    // Put other blank
                    brush = (Brush)converter.ConvertFromString("#ffffff");
                    PersonalFinanceButton.Foreground = brush;
                    SoleTraderTypeButton.Foreground = brush;
                    WarehouseStoreButton.Foreground = brush;
                    break;
                case 3:
                    brush = (Brush)converter.ConvertFromString("#F29705");
                    SoleTraderTypeButton.Foreground = brush;

                    // Put other blank
                    brush = (Brush)converter.ConvertFromString("#ffffff");
                    PersonalFinanceButton.Foreground = brush;
                    RetailStoreButton.Foreground = brush;
                    WarehouseStoreButton.Foreground = brush;
                    break;
            }

        }

        private void SoleTraderTypeButton_Click(object sender, RoutedEventArgs e)
        {
            companyType = "SoleTrader";

            ChangeButtonForegroundColor(3);

            SoleTraderTypeWindow window = new SoleTraderTypeWindow(currentUser);
            window.Owner = this;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.Show();

            // Sets the owner to the new window so that the user can close the StarterWindow and 
            // the program not close.
            window.Owner = null;
            this.Owner = window;
            this.Close();
        }


        private void PersonalFinanceButton_Click(object sender, RoutedEventArgs e)
        {
            companyType = "PersonalFinace";

            ChangeButtonForegroundColor(0);

            PersonalFinanceWindow window = new PersonalFinanceWindow(currentUser);
            window.Owner = this;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.Show();

            // Sets the owner to the new window so that the user can close the StarterWindow and 
            // the program not close.
            window.Owner = null;
            this.Owner = window;
            this.Close();
        }

        private void RetailStoreButton_Click(object sender, RoutedEventArgs e)
        {
            companyType = "RetailStore";

            RetailStoreTypeWindow window = new RetailStoreTypeWindow(currentUser);
            window.Owner = this;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.Show();

            // Sets the owner to the new window so that the user can close the StarterWindow and 
            // the program not close.
            window.Owner = null;
            this.Owner = window;
            this.Close();

            ChangeButtonForegroundColor(2);
        }

        private void WarehouseStoreButton_Click(object sender, RoutedEventArgs e)
        {
            companyType = "WarehouseStore";

            ChangeButtonForegroundColor(1);
        }
    }
}

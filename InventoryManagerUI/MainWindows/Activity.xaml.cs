using InventoryManagerUI.MainWindows.ActivityPages;
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
    /// Interaction logic for Activity.xaml
    /// </summary>
    public partial class Activity : Window
    {
        public Activity()
        {
            InitializeComponent();

            Home homePage = new Home();
            navigationFrame.NavigationService.Navigate(homePage);

        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeForegroundColor(0);

            Home page = new Home();
            navigationFrame.NavigationService.Navigate(page);
        }

        private void SpendingButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeForegroundColor(1);

            Spending page = new Spending();
            navigationFrame.NavigationService.Navigate(page);
        }

        private void BillsButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeForegroundColor(2);
        }

        private void Planning_Click(object sender, RoutedEventArgs e)
        {
            ChangeForegroundColor(3);
        }

        private void InvestingButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeForegroundColor(4);
        }

        public void ChangeForegroundColor(int page)
        {
            var converter = new System.Windows.Media.BrushConverter();

            switch (page)
            {
                case 0:
                    var brush = (Brush)converter.ConvertFromString("#F29705");
                    HomeButton.Foreground = brush;

                    // Put other blank
                    brush = (Brush)converter.ConvertFromString("#ffffff");
                    SpendingButton.Foreground = brush;
                    BillsButton.Foreground = brush;
                    PlanningButton.Foreground = brush;
                    InvestingButton.Foreground = brush;
                    break;
                case 1:
                    brush = (Brush)converter.ConvertFromString("#F29705");
                    SpendingButton.Foreground = brush;

                    // Put other blank
                    brush = (Brush)converter.ConvertFromString("#ffffff");
                    HomeButton.Foreground = brush;
                    BillsButton.Foreground = brush;
                    PlanningButton.Foreground = brush;
                    InvestingButton.Foreground = brush;
                    break;
                case 2:
                    brush = (Brush)converter.ConvertFromString("#F29705");
                    BillsButton.Foreground = brush;

                    // Put other blank
                    brush = (Brush)converter.ConvertFromString("#ffffff");
                    SpendingButton.Foreground = brush;
                    HomeButton.Foreground = brush;
                    PlanningButton.Foreground = brush;
                    InvestingButton.Foreground = brush;
                    break;
                case 3:
                    brush = (Brush)converter.ConvertFromString("#F29705");
                    PlanningButton.Foreground = brush;

                    // Put other blank
                    brush = (Brush)converter.ConvertFromString("#ffffff");
                    SpendingButton.Foreground = brush;
                    HomeButton.Foreground = brush;
                    BillsButton.Foreground = brush;
                    InvestingButton.Foreground = brush;
                    break;
                case 4:
                    brush = (Brush)converter.ConvertFromString("#F29705");
                    InvestingButton.Foreground = brush;

                    // Put other blank
                    brush = (Brush)converter.ConvertFromString("#ffffff");
                    SpendingButton.Foreground = brush;
                    HomeButton.Foreground = brush;
                    BillsButton.Foreground = brush;
                    PlanningButton.Foreground = brush;
                    break;
            }
            
        }

 
    }
}

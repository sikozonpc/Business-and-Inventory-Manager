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

namespace InventoryManagerUI.MainWindows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();

            DisplayLastLoggedUser();
        }

        private void DisplayLastLoggedUser()
        { 
            // Sets the username of the last logged in member already typed in
            foreach(var i in SqliteDataAccess.GetLastLoggedInUser())
            {
                usernameField.Text = i.Username;
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            UserModel user = new UserModel();
            user.Username = usernameField.Text;
            user.Password = passwordField.Password;

            // Searches the user in the list with the given users
            // ( Im not using a search SQL querry command because the users list is small 
            // and this is just a simple way of login in, since the database will be in the machine 
            // that the application will be operated) 
            List<UserModel> logedInUser = SqliteDataAccess.LoginUser(user);

            // Temporary bool to show the error message if the user doesn't exist in the database
            bool existsUser = false;

            foreach(var i in logedInUser)
            {
                if (user.Username == i.Username && user.Password == i.Password)
                {
                    existsUser = true;
                    // If its the first time the user logs in , show the startup page 
                    if (i.FirstTime == 1)
                    {
                        // Change the FirstTime value to 0 because he logged in now
                        SqliteDataAccess.ChangeUserFirstTime(i, 0);
                        SqliteDataAccess.UpdateLoggedinUser(user);

                        // Sets the current id in the session on the company variables
                        CompanyVariables.CurrentLoggedInUserID = SqliteDataAccess.GetUserID(user);

                        StarterWindow window = new StarterWindow(user);
                        window.Owner = this;
                        window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                        window.Show();

                        // Sets the owner to the new window so that the user can close the StarterWindow and 
                        // the program not close.
                        window.Owner = null;
                        this.Owner = window;
                        this.Close();
                    }
                    else
                    {
                        SqliteDataAccess.UpdateLoggedinUser(user);

                        // Sets the current id in the session on the company variables
                        CompanyVariables.CurrentLoggedInUserID = SqliteDataAccess.GetUserID(user);

                        // Logs in 
                        MainWindow window = new MainWindow(i.CompanyType);
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

             if (existsUser == false)
            {
                MessageBox.Show("Username or Password don't exist.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void RegisterButtpn_Click(object sender, RoutedEventArgs e)
        {
            UserModel user = new UserModel();
            user.Username = usernameField.Text;
            user.Password = passwordField.Password;

            SqliteDataAccess.RegisterUser(user);

            MessageBox.Show("User sucessfulyy registred. Now you can login with it.", "Registed user", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}

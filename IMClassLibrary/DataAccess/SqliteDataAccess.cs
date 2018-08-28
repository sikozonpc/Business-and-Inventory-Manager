using Dapper;
using IMClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMClassLibrary
{

    // TODO - REMAKE using Generics and List<T> !!!!!!!!!!!!!!


    public class SqliteDataAccess
    {
        // PRODUCTS DATA


        public static List<ProductModel> LoadProducts()
        {
            using ( IDbConnection cnn = new SQLiteConnection( LoadConnectionString() ) )
            {
                var output = cnn.Query<ProductModel>("select * from Products", new DynamicParameters() );

                return output.ToList();
            }
        }

        public static void SaveProduct(ProductModel product)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString() ) )
            {
                cnn.Execute("insert into Products (Name, Type, Quantity, Price, Provider, ReceiptDate, Location) values (@Name, @Type, @Quantity, @Price, @Provider, @ReceiptDate, @Location)", product);
            }
        }

        public static void RemoveProduct(ProductModel product)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Products WHERE Id='" + product.Id + "'", product);
            }
        }


        // EMPLOYEE DATA


        public static List<EmployeeModel> LoadEmployees()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<EmployeeModel>("select * from Employees", new DynamicParameters());

                return output.ToList();
            }
        }


        public static void SaveEmployee(EmployeeModel employee)
        {
            using(IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Employees (FirstName, LastName, Birthday, JobRole, Salary, ContactNumber, Adress) values (@FirstName, @LastName, @Birthday, @JobRole, @Salary, @ContactNumber, @Adress)", employee);
            }
        }

        public static void RemoveEmployee(EmployeeModel employee)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Employees WHERE Id='" + employee.Id + "'", employee);
            }
        }


        // COMPANY DATA


        public static void SaveNewCompany(CompanyModel company)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Companies (LinkedUserID, CompanyName, CurrentMonthBudget, CurrentMonthSpent, LastMonthSpending, LastYearTotalSpending, TotalSpending, Currency, BusinessType)" +
                    " values (@LinkedUserID, @CompanyName, @CurrentMonthBudget, @CurrentMonthSpent, @LastMonthSpending, @LastYearTotalSpending, @TotalSpending, @Currency, @BusinessType)", company);
            }
        }

        public static List<CompanyModel> LoadCompanies()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CompanyModel>("select * from Companies", new DynamicParameters());

                return output.ToList();
            }
        }

        public static List<CompanyModel> LoadCompany(int LinkedUserID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CompanyModel>("SELECT * from Companies WHERE LinkedUserID =" + LinkedUserID , new DynamicParameters());

                return output.ToList();
            }
        }


        public static void SaveCompanyData(CompanyModel currentSeasion)
        {
            // TODO 
        }


        public static void SaveNewPersonalFincance(PersonalFinanceModel owner)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into PersonalFinances (LinkedUserID, OwnerName, TotalIncome, Expenses, HouseRents, Debts, Currency, BusinessType)" +
                    " values (@LinkedUserID, @OwnerName, @TotalIncome, @Expenses, @HouseRents, @Debts, @Currency, @BusinessType)", owner);
            }
        }

        public static List<PersonalFinanceModel> LoadPersonalFinances()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonalFinanceModel>("select * from PersonalFinances", new DynamicParameters());

                return output.ToList();
            }
        }

        public static string GetCompanyType()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select * from PersonalFinances", new DynamicParameters());

                return output.ToString();
            }
        }
        // USER DATA


        public static void RegisterUser(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Users (Username, Password, FirstTime, CompanyType) values (@Username, @Password, @FirstTime, @CompanyType)", user);
            }
        }

        public static List<UserModel> LoginUser(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("select * from Users", new DynamicParameters());

                return output.ToList();
            }
        }

        public static void ChangeUserFirstTime(UserModel user, int value)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Users SET FirstTime ='" + value + "' WHERE Username = '" +
                    user.Username + "'", user);
            }
        }

        public static int GetUserID(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("select * from Users", new DynamicParameters());

                // Gets the current user ID from the auto generated ID's created in the Database
                int id = 0;
                foreach (var i in output)
                {
                    if (i.Username == user.Username)
                    {
                        id = i.Id;
                    }
                }

                return id;
            }
        }

        public static void UpdateLoggedinUser(UserModel user)
        {
            int id = GetUserID(user);

            using ( IDbConnection cnn = new SQLiteConnection(LoadConnectionString() ))
            {
                cnn.Execute("UPDATE LoggedInUser SET Username='"+ user.Username +"' , Id='"+ id + "'", user);
            }
        }

        public static void UpdateCompanyType(UserModel user, string companyType)
        {
            int id = GetUserID(user);

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Users SET CompanyType='" + companyType + "' WHERE Id='" + id + "'", user);
            }
        }

        public static List<UserModel> GetLastLoggedInUser()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("select * from LoggedInUser", new DynamicParameters());

                return output.ToList();
            }
        }


        // CONNECTION STRING 

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

          }
}


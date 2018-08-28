using IMClassLibrary.DataAccess;
using IMClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMClassLibrary.Helper
{
    public static class HelperClass
    {
        public static void WriteCurrentLoggedCompanyToVariables(CompanyModel company)
        {
            // Write to the local static CompanyVariables the data so it 
            // can be used and displayed on the application
            CompanyVariables.CompanyName = company.CompanyName;
            CompanyVariables.CurrentMonthBudget = company.CurrentMonthBudget;
            CompanyVariables.CurrentMonthSpent = company.CurrentMonthSpent;
            CompanyVariables.Currency = company.Currency;
            CompanyVariables.CurrentLoggedInUserID = company.LinkedUserID;
            CompanyVariables.TotalSpending = company.TotalSpending;
        }

        public static void WriteCurrentLoggedPersonalFincanceToVariables(PersonalFinanceModel owner)
        {
            // Write to the local static CompanyVariables the data so it 
            // can be used and displayed on the application
            CompanyVariables.CompanyName = owner.OwnerName;
            CompanyVariables.Currency = owner.Currency;
            CompanyVariables.CurrentLoggedInUserID = owner.LinkedUserID;
        }
    }
}

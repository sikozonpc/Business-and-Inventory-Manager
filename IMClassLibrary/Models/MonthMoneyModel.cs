using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMClassLibrary.Models
{
    // The main reason I used a model for this type of data is because I want the user/ company that uses
    // the application the be able to store his / their monthly spendings as long as they want.
    // And so with this approach it's possible to store as many years spendings records.

    public class MonthMoneyModel
    {
        public int Year { get; set; }

        // From 0 - 12 , which correspond to every month in a year 
        public float[] MonthValues = new float[12];

        
        public MonthMoneyModel(int year, float january, float february, float march, float april ,float may, float june,
            float july, float august, float setpember, float october, float november, float december)
        {
            this.Year = year;

            MonthValues[0] = january;
            MonthValues[1] = february;
            MonthValues[2] = march;
            MonthValues[3] = april;
            MonthValues[4] = may;
            MonthValues[5] = june;
            MonthValues[6] = july;
            MonthValues[7] = august;
            MonthValues[8] = setpember;
            MonthValues[9] = october;
            MonthValues[10] = november;
            MonthValues[11] = december;
        }
    }
}

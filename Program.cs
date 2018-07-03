using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PayRate payRate = new PayRate();
            Console.WriteLine("Please enter your paycheck amount. \n Make sure to enter it as a whole number, then press enter.");
            int weeklyAmt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Now, enter the amount of hours you worked last week. \n Make sure to enter it as a whole number, then press enter. ");
            bool weeklytotal = Int32.TryParse(Console.ReadLine(), out int weeklyHrs);
            Console.WriteLine();
            if (weeklytotal)
            {
                Console.WriteLine("You make about: "+ payRate.payRateAdjuster(weeklyAmt, weeklyHrs)+ "  per hour.");
            }
            else
            {
                Console.WriteLine("This won't add up because the default part-time hours are 30, but if you insist, your rate would be: "+ payRate.payRateAdjuster(weeklyAmt));
            }
            Console.ReadLine();

            Console.WriteLine("Calling the method and specifiying the parameters by name with weeklyAnount as 100 and weeklyHours as 20.");
            Console.WriteLine(payRate.payRateAdjuster(weeklyAmount: 100, weeklyHours: 20));
            Console.ReadLine();
            
            

        }

    }
}

// Pierce Carnell
// 2/10/2022
// ISM 4300
// T3
using System;

namespace Carnell_T3
{
    class Program
    {
        //Construct Variables
        static double cadVal = 0;
        static double usdVal = 0;
        static double conversion = 0.792367;
        static double incVal;
        static void Main(string[] args)
        {

            //Prompt user for input
            promptUser();

            //Validate user input is between 5 and 25
            while (cadVal < 5 || cadVal > 25)
            {
                Console.WriteLine("Invalid input: Value must be between 5 and 25");
                promptUser();
            }

            //Convert initial CAD value to USD
            convertCurrency();

            //Increment and print conversions
            incAndPrint();
        }

        //Method to prompt user for CAD input and store input as cadVal
        static void promptUser()
        {
            Console.WriteLine("Please enter a CAD amount between 5 and 25");
            cadVal = Convert.ToDouble(Console.ReadLine());
            incVal = cadVal;
        }

        //Method to convert CAD to USD
        static void convertCurrency()
        {
            usdVal = cadVal * conversion;
        }

        //Method to increment and print conversions
        static void incAndPrint()
        {
            Console.WriteLine("CAD      USD");
            Console.WriteLine("$0.00    $0.00");

            while (cadVal < 200)
            {
                Console.WriteLine("$" + cadVal.ToString("0.00") + "   $" + usdVal.ToString("0.00"));
                cadVal += incVal;
                convertCurrency();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpressAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.ReadLine();
           


            Console.WriteLine("What is your Package weight?");
            string packageWeight = Console.ReadLine();
            int packweight = Convert.ToInt32(packageWeight);
            string result = Console.ReadLine();
            if (packweight >= 50)
            {
                Console.WriteLine("Your Package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return ;
            }
            else
            {
                Console.WriteLine("Package Accepted");
            }
            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine("What is your package width?");
            string packageWidth = Console.ReadLine();
            int packWidth = Convert.ToInt32(packageWidth);
            Console.WriteLine("your package width is:" + packageWidth);
            Console.ReadLine();

            Console.WriteLine("What is your package height?");
            string packageHeight = Console.ReadLine();
            int packheight = Convert.ToInt32(packageHeight);
            Console.WriteLine("Your package height is: " + packageHeight);
            Console.ReadLine();

            Console.WriteLine("What is your package Length?");
            string packageLength = Console.ReadLine();
            int packlength = Convert.ToInt32(packageLength);
            Console.WriteLine("Your package length is:" + packageLength);
            Console.ReadLine();

            int totalDmension = (packWidth * packheight * packlength);

            Console.WriteLine("What is the total dimension?");
            string totalDimension = Console.ReadLine();
            int totdimension = Convert.ToInt32(totalDimension);
            string resultTotal = Console.ReadLine();

            if (totdimension >= 50)
            {
                Console.WriteLine(" Your package is too heavy to be shipped via Package Express. Have a good day. ");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Package Accepted");
            }

            Console.WriteLine(resultTotal);
            Console.ReadLine();

            var DollarValue = totalDimension;
            Console.WriteLine(DollarValue);
            Console.ReadLine();

            Console.WriteLine("Your estimated total for shipping this package is: $528.00 " + "Thank you!");
            Console.ReadLine();           
        }    
 
    }
}
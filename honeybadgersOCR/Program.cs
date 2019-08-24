using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace honeybadgersOCR
{
    class Program
    {
        static void Main(string[] args)
        {
            string imageFilePath = @"C:\Users\sabin\Desktop\honeybadger\coupon\1.PNG";

            if (File.Exists(imageFilePath))
            {
                // Call the REST API method.
                Console.WriteLine("\nWait a moment for the results to appear.\n");
                
                Rest.MakeOCRRequest(imageFilePath).Wait();
            }
            else
            {
                Console.WriteLine("\nInvalid file path");
            }
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}

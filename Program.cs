using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp2
{
    internal class Program
    {
        public static int obtaintime()
            {
            int h;
            int m;
            string inputval;
            const int mperhours = 60;
            int totalminutes;
            WriteLine("pls enter total hours");
    
            inputval = ReadLine();
            h = int.Parse(inputval);
            WriteLine("pls enter total minutes");

            inputval = ReadLine();
            m = int.Parse(inputval);
            totalminutes = m + (h / mperhours);
            return totalminutes;
            }
        public static double calculatestrides()

        {
            int firstms;
            int lastms;
            
            string inputval;
            double avgstrides;
            
            WriteLine("pls enter strides made in first minute");

            inputval = ReadLine();
            firstms = int.Parse(inputval);
            WriteLine("pls enter strides made in last minute");

            inputval = ReadLine();
            lastms = int.Parse(inputval);
            avgstrides = (firstms+lastms)/2.0;
            return avgstrides;
            
            }


        static void Main(string[] args)
        {
            /*input time
             *return in minutes
             *input strides
             *return average stridesinAminute
             *calculate distance in m*/
            const double stride_to_feet = 2.5;
            double feetperminute;
            double totalfeet;
            double totalmiles;
            int totaltimeinminutes;
            double averagestrides;
            
            totaltimeinminutes = obtaintime();
            averagestrides=calculatestrides();
           
            feetperminute = stride_to_feet * averagestrides;
            totalfeet = feetperminute * totaltimeinminutes;
            totalmiles = totalfeet / 5280.0;
            WriteLine("total mile" + totalmiles);
            ReadKey(); 
        }
    }
}

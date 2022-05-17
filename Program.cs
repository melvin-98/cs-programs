using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace carpetcalculator
{
    internal class Program
    {
        public static double unitConversion(double n1, double n2,int convertconst)
        {
            return n1 + (double)n2 /convertconst;
        }
        static void Main(string[] args)
        {
            const int inchesperfoot = 12;
            const int sqft_sqyd = 9;
            const double priceberber= 27.95;
            const double  pricepile=15.95;
            int roomlFeet = 12;
            int roomlInches = 2;
            int roomWfeet = 14;
            int roomWinches = 7;
            /* convert unit to feet
          * caluculate area
          * convert area to square yard
          * calculate total cost */
            double roomL;
            double roomW;
            roomL = unitConversion(roomlFeet,inchesperfoot,inchesperfoot);
            roomW = unitConversion(roomWfeet, inchesperfoot, inchesperfoot);
            
            double area = roomW * roomL;
            //roomW = roomWfeet + (double)roomWinches / inchesperfoot;
            
            double areasqyd =unitConversion(0,area,sqft_sqyd);
            
            //double area=(roomW*roomL)/sqft_sqyd;
            WriteLine("the area is {0,0:F4} in SQyard", areasqyd);
            double totalcostberber;
            totalcostberber = priceberber * area;
            double totalcostpile = pricepile * area;
            WriteLine("");
            ReadKey();
        }
    }
}

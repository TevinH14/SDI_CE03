using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamilton_Tevin_RestaurantCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tevin Hamilton
             * restaurant calculator 
             * 05/04/18
             */
            Console.Clear();
            Console.WriteLine("welcome new user\r\n");

            // prompt the user for prices of meal 1
            Console.WriteLine("what is the price for meal 1.\r\n");
            //capture the user respones 
            string meal1PriceString = Console.ReadLine();
            //convert the string data typr to a number data type
            decimal meal1Price = decimal.Parse(meal1PriceString);

            //prompt the user for the price of meal 2
            Console.WriteLine("what is the price for meal 2.\r\n");
            //capture the user responsed 
            string meal2PriceString = Console.ReadLine();
            //convert string into number data type 
            decimal meal2Price = decimal.Parse(meal2PriceString);

            // prompt the user for the price of meal 3 
            Console.WriteLine("what is the price of meal 3.\r\n");
            //capture the user responds 
            string meal3PriceString = Console.ReadLine();
            //convert string into data type 
            decimal meal3Price = decimal.Parse(meal3PriceString);

            // promt the user for tip 1 for meal 1.
            Console.WriteLine("what is the tip percentage you will like to give for meal 1.\r\n");
            //capture user repsone 
            string tip1NCString = Console.ReadLine();
            //convert string into a double 
             decimal tipNC = decimal.Parse(tip1NCString);
            decimal tip = tipNC / 100;

            //promt the user for tip 2 for meal 2 
            Console.WriteLine("what is the tip percentage you will like to give for meal 2.\r\n ");
            //capture the user respones 
            string tip2NCString = Console.ReadLine();
            //convert string into a double 
            decimal tipNC2 = decimal.Parse(tip2NCString);
            //convert whole number into a percentage
            decimal tip2 = tipNC2 / 100;

            //prompt the user for tip 3 
            Console.WriteLine("what is the tip percentage you will like to give for meal 3.\r\n");
            //capture the user respones 
            string tipNC3String = Console.ReadLine();
            //convert into double 
            decimal tipNC3 = decimal.Parse(tipNC3String);
            //convert into a percentage 
            decimal tip3 = tipNC3 / 100;

            decimal meal1TipAmount = meal1Price * tip;
            decimal meal1Total = meal1Price + meal1TipAmount;
            /*TEST
            Console.WriteLine(meal1Total.ToString("c"));
            */
            decimal meal2TipAmount = meal2Price * tip2;
            decimal meal2Total = meal2Price + meal2TipAmount;

            decimal meal3TipAmount = meal3Price * tip3;
            decimal meal3Total = meal3Price + meal3TipAmount;

            Console.WriteLine($"The total for meal one with tip is {meal1Total.ToString("c")}\r\n");
            Console.WriteLine($"The total for meal two with tip is {meal2Total.ToString("c")}.\r\n");
            Console.WriteLine($"The total for meal three with tip is {meal3Total.ToString("c")}.\r\n");

            //The total cost of all the tips
            decimal tipTotal = meal1TipAmount + meal2TipAmount + meal3TipAmount;
            Console.WriteLine($"The total of all the tips from all 3 meals is are {tipTotal.ToString("c")}");

            // total of all three checks if one person was paying 
            decimal completeTotal = meal1Total + meal2Total + meal3Total;
            Console.WriteLine($"If one person is to pay the full bill with tips the total would come out to be {completeTotal.ToString("c")} ");

            //the total if 3 of the guest split the bill 
            decimal threeWayBill = completeTotal / 3;
            Console.WriteLine($"If all three of the guest was to slpit the bill the total eill be {threeWayBill.ToString("c")}");

            /*
             * test 1 
             * check 1-10.00
             * check 2 -15.00
             * check 3 - 25.00
             * tip1-15
             * tip2 -15
             * tip3 -20
             * checck 1 and tip1 11.50 (10.00*.15= 1.5.   10.00+1.5=11.50)
             * check2 and tip 2 17.25(15.00*.15=2.25   15.00+ 2.25=17.25)
             * check3 and tip3 30.00(25*.20=5     25+5=30)
             * tip total - 8.75(1.5+2.25+5=8.75)
             * check 1,check 2 and check3 total with tip 58.75(11.50+17.25+30.00=58.75
             * meal total split 3 ways -19.58(58.75/3=19.58 )
             * test2 
             * check1- 24.50
             * check2- 17.25
             * check3- 31.00
             * tip1- 15
             * tip2- 25
             * tip3- 20
             * check1 and tip1-28.18(24.50*.15=3.675 24.50+3.675=28.175)
             * check2 and tip- 21.56(17.25*.25=4.3125  17.25+4.3125=21.56)
             * check3 and tip3 37.20(31.00*.2=6.2   31.00+6.2=37.20)
             * tip total 14.19(3.675+4.3125+6.2=14.19)
             * checks and tips total- 86.94(add all checks and tips together d)
             * check being split 3 ways 86.94/3=28.98
             * */
            
           

        }
    }
}

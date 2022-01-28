using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Deliverable2
    // Buffet program that takes drink order and provides a bill
{
    internal class Program { 

            
        static void Main(string[] args)
        {

        //  set array size to user input 
        Console.WriteLine("Welcome to the Grand Circus buffet!  \n");
            Console.WriteLine("How many people are in your group?  ");
            string sSize = Console.ReadLine();
            int i = Convert.ToInt32(sSize);
            int[] size = new int[i];
            int max = 6;
            double costCoffee = 2.00;
            double costPerPerson = 9.99;



            // if else to break if size of party is too large
            if (i > max)
            {
                Console.WriteLine("Sorry, we can't take a group bigger than six. \n Have a nice day!");
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();

            } //end if

            else
            {


                // create list for drinks ordered
                var drink = new List<string>();

                Console.WriteLine("\nWe like to keep it simple here - for beverages we either have water for free or a coffee for $2.00. ");



                for (int a = 0; a < i; a++)
                {          


                    Console.WriteLine("\n\nGuest " +(a + 1) + " , what would you like to drink? ");

                    drink.Add(Console.ReadLine());
                    string last = drink[drink.Count - 1];
                    Console.WriteLine(last + ", you got it...\n");

                    /* attempt to do match case for drink order. Unfortunately i couldn't figure it out
                     * 
                    Match match = Regex.Match(last, @"water$",
                         RegexOptions.IgnoreCase);
                    Match match2 = Regex.Match(last, @"coffee$",
                        RegexOptions.IgnoreCase);       
                    */

                        
                        Console.WriteLine("\tand for your second drink?");
                        drink.Add(Console.ReadLine());
                        string last2 = drink[drink.Count - 1];
                        Console.WriteLine("and " + last2 + ", nice choices. \n");


                } 

                Console.WriteLine("\nThank you for your drink order");
                // count number of waters and coffee in list
                int countWater = drink.FindAll(drink => drink.StartsWith("w")).Count;
                Console.WriteLine("\n\nI have a total of " + countWater + " waters");
                int countCoffee = drink.FindAll(drink => drink.StartsWith("c")).Count;
                Console.WriteLine("and " + countCoffee + " coffees");

                Console.WriteLine("\n\nHere is your bill for a party of " + sSize + " ;");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("");


                int calc = Int32.Parse(sSize);
                Console.WriteLine(sSize +" people X $9.99 = $" +calc * costPerPerson);
                Console.WriteLine(countWater + " complimentary waters =  $" + countWater * 0);
                Console.WriteLine(countCoffee+ " coffee X $2.00 = $" +Math.Round(countCoffee * costCoffee,2));
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("");

                Console.WriteLine("Hope you enjoy your meal! \n");
                
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();
            }
        }   
    }
}


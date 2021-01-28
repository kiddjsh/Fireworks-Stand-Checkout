using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireWork_W5iLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable list
            string user = "";
            string noDiscount = "";
            double purchasePrice = -1;
            double discountPrice = 0;
            double itemNumber = 1;


            //inputs
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello! Welcome to the Firework Stand!");
            Console.WriteLine("To end the program at any time, at item price, enter -1");
            user = Console.ReadLine();            
            Console.WriteLine("Please enter shopper's name: ");
            user = Console.ReadLine();
            user = Console.ReadLine();
            Console.WriteLine("Remember! Items over $50.00 receive a 10% Discount.");
            Console.WriteLine("Happy Shopping!");
            user = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;

            //calculations
            do
            {
                user = Console.ReadLine();
                Console.WriteLine("Enter the price of the item: $");
                purchasePrice = Convert.ToDouble(Console.ReadLine());
                if (purchasePrice!=-1)
                {
                    //decision
                    if (purchasePrice >= 50)
                    {
                        discountPrice = purchasePrice - (purchasePrice * 0.10);
                        Console.WriteLine("You purchased this item for $" + purchasePrice + ", your discounted price is $" + discountPrice);
                        itemNumber++;
                    }
                    //decision
                    else
                    {
                        noDiscount = ", with a discounted price of $0.00";
                        Console.WriteLine("You purchased this item for $" + purchasePrice + noDiscount);
                        itemNumber++;
                    }                                     
                }
            }while (purchasePrice!=-1);  //this is the only time you need a semicolon ; do--while loop

            //output messages  
            user = Console.ReadLine();
            Console.WriteLine("Thank you for shopping at the Firework Stand!");

            Console.ReadLine(); //leaves the window open
        }
    }
}

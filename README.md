# Fireworks-Stand-Checkout
An application, using a solution algorithm that employs loops, that keeps track of customers purchases. The application accepts the dollar value of each item purchased as input until finished. When purchases are complete, a sentinel value  of -1 is entered to indicate the process has finished. If the item purchased is $50.00 or more, a 10% discount on the  item purchased is applied. All purchases display with the original price and the discount price. 

# IPO Model
![Variables & IPO Model](https://raw.githubusercontent.com/kiddjsh/Fireworks-Stand-Checkout/main/images/IPO%20Model.PNG)

# Flowchart
![Flowchart_1](https://raw.githubusercontent.com/kiddjsh/Fireworks-Stand-Checkout/main/images/Flowchart_1.PNG)
![Flowchart_2](https://raw.githubusercontent.com/kiddjsh/Fireworks-Stand-Checkout/main/images/Flowchart_2.PNG)
![Flowchart_3](https://raw.githubusercontent.com/kiddjsh/Fireworks-Stand-Checkout/main/images/Flowchart_3.PNG)

# My C# Solution
```C#
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
            Console.ForegroundColor = ConsoleColor.Green;

            //calculations
            do
            {
                user = Console.ReadLine();
                Console.WriteLine("Enter the price of the item: ");
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
```

# Complete Working Program
![Complete Working Program](https://raw.githubusercontent.com/kiddjsh/Fireworks-Stand-Checkout/main/images/Complete%20Working%20Program.PNG)


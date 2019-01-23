using System;

namespace bobs_burgers
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax = 0.06875;
            double grandTotal; //subtotal time tax output to user after final order submitted
            double finalTotal;
            double subtotal;
            double grandTotalRounded;

            //process
            subtotal = 0.0;
            finalTotal = createOrder(subtotal);

            grandTotal = finalTotal + (finalTotal * tax);

            grandTotalRounded = Math.Round(grandTotal, 2);
            //output
            Console.WriteLine("Your order total plus tax will be $" + grandTotalRounded + " Thank you for eating at Bob's Burgers. Have a Nice Day!");
            Console.ReadLine();

        }
//TODO: Why are you passing in Subtotal here? Will it ever be non 0?
        private static double createOrder(double subtotal)
        {
            //setup
            string order ="";
            double burger = 2.99;
            double fries = 1.99;
            double drink = 0.99;
            double bobbyMeal = 5.00;

            //input
            do
            {
//TODO: refactor menu into its own method single action priciple
                //menu
                Console.WriteLine("Welcome to Bob's burgers!");
                Console.WriteLine("1.) Burger = $2.99");
                Console.WriteLine("2.) Fries = $1.99");
                Console.WriteLine("3.) Drink = $.99");
                Console.WriteLine("4.) Bobby Meal = $5.00 a burger, fry and drink");
                
//TODO: please validate your user input
                order = Console.ReadLine();

                if (order == "1")
                {
                    subtotal = subtotal + burger;
                }
                else if (order == "2")
                {
                    subtotal = subtotal + fries;
                }
                else if (order == "3")
                {
                    subtotal = subtotal + drink;
                }
                else
                {
                    subtotal = subtotal + bobbyMeal;
                }
//TODO: please validate your data input
                Console.WriteLine("Finished ordering? Yes = Y, No = type a key");
                order = Console.ReadLine();
            } while (order.ToUpper() != "Y");

            return (subtotal);
        }
    }
}

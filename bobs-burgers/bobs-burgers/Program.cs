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
            finalTotal = CreateOrder(subtotal);

            grandTotal = finalTotal + (finalTotal * tax);

            grandTotalRounded = Math.Round(grandTotal, 2);
            //output
            Console.WriteLine("Your order total plus tax will be $" + grandTotalRounded + " Thank you for eating at Bob's Burgers. Have a Nice Day!");
            Console.ReadLine();

        }
//TODO: Why are you passing in Subtotal here? Will it ever be non 0?
//Rebuttle: We set subtotal equal to 0.0 because when the program runs the user is starting a new order therefore their subtotal at start is 0 until the program conpiles the Menu and CreateOrder method will subtotal change base on user inputs. Also subtotal being 0 at the start of the program helped with the loop in CreateOrder working properly.
        private static double CreateOrder(double subtotal)
        {
            //setup
            double burger = 2.99;
            double fries = 1.99;
            double drink = 0.99;
            double bobbyMeal = 5.00;
            string answer = "";
            Single order;

            //input
            do
            {
                order = Menu();

                    if (order == 1)
                    {
                        subtotal = subtotal + burger;
                    }
                    else if (order == 2)
                    {
                        subtotal = subtotal + fries;
                    }
                    else if (order == 3)
                    {
                        subtotal = subtotal + drink;
                    }
                    else
                    {
                        subtotal = subtotal + bobbyMeal;
                    }

                //TODO: please validate your data input - done
                do
                {
                    Console.WriteLine("Finished ordering? Yes = Y or No = N");
                    answer = Console.ReadLine();
                } while (answer.ToUpper() != "Y" && answer.ToUpper() != "N");
            } while (answer.ToUpper() != "Y");

            return (subtotal);
        }

        //TODO: refactor menu into its own method single action priciple -done
        private static Single Menu()
        {
            Single orderMenu;
            //TODO: please validate your user input - done
            do
            {
                Console.WriteLine("Welcome to Bob's burgers!");
                Console.WriteLine("1.) Burger = $2.99");
                Console.WriteLine("2.) Fries = $1.99");
                Console.WriteLine("3.) Drink = $.99");
                Console.WriteLine("4.) Bobby Meal = $5.00 a burger, fry and drink");

                orderMenu = Single.Parse(Console.ReadLine());
            } while (orderMenu != 1 && orderMenu != 2 && orderMenu != 3 && orderMenu != 4);
            return orderMenu;
        }
    }
}

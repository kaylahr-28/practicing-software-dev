using System.Xml.Linq;

namespace practicing_software_dev
{
    internal class Restaurant
    {
        static void Main(string[] args)
        {
            //initialize Queue "Orders" - Kaylah
            Queue<Order> OrderQueue = new Queue<Order>();

            string name, item;
            int quantity;
            bool ordering = true;
            string yesOrNo;

            //welcome text
            Console.WriteLine("Welcome to our restaurant!");

            //while-loop: while user input != empty line, "what can i get you" , prompt for dish name, quantity, who it's for
            do
            {
                item = Console.ReadLine("What dish would you like?");

               try
               {
                    string quantityInput = Console.ReadLine("How many would you like?");
                    quantity = int.Parse(input);
                }

               catch (FormatException ex)
               {
                    Console.WriteLine("Please enter an integer");
               }


                name = Console.ReadLine("What is the name for the order?");

               

                ordering = Console.ReadLine("Would you like to keep ordering? Please type 'true' to keep ordering and 'false' to stop.");
                try
                {
                    string orderInput = Console.ReadLine("Would you like to keep ordering? Please type 'true' to keep ordering and 'false' to stop.");
                    ordering = bool.Parse(input);
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("Please type 'true' to keep ordering and 'false' to stop.");
                }


                //make Order object for each user input of an order, add to Queue - Vicky
                Order order = new Order(name, item, quantity);
                OrderQueue.Enqueue(order);
            } while (ordering);

            

            //"kitchen making orders yay"
            Console.WriteLine("We'll be right back with your orders!");

            //for loop: dequeues to "make" orders
            for ()
            {

            }

            //print " heres your order (dish, quantity, name) yippiee"


            //"enjoy!"
            Console.WriteLine("We hope you enjoy your meal!");
        }
    }

    //2nd internal class Order - make one object for every order they make, store in Queue - Meghan
    internal class Order
    {
        string personWhoOrdered;
        string itemName;
        int quantity;

        public Order(string personWhoOrdered, string itemName, int quantity)
        {
            this.personWhoOrdered = personWhoOrdered;
            this.itemName = itemName;
            this.quantity = quantity;
        }

        public string Make()
        {
            return "Here is the " + quantity + " orders of " + itemName + " for " + personWhoOrdered;
        }
    }
}

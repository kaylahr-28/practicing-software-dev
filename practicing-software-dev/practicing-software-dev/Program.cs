namespace practicing_software_dev
{
    internal class Restaurant
    {
        static void Main(string[] args)
        {
            //initialize Queue "Orders" - Kaylah
            Queue<Order> OrderQueue = new Queue<Order>();

            //welcome text
            Console.WriteLine("Welcome to our restaurant!");

            //while-loop: while user input != empty line, "what can i get you" , prompt for dish name, quantity, who it's for
            do
            {
                Console.WriteLine("What dish would you like?");


                Console.WriteLine("How many would you like?");


                Console.WriteLine("What is the name for the order?");


            } while ();

            //for each line of user input, make sure its correct numbers/type/etc

            //make Order object for each user input of an order, add to Queue

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

namespace practicing_software_dev
{
    internal class Restaurant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //initialize Queue "Orders"


            //welcome text


            //while-loop: while user input != empty line, "what can i get you" , prompt for dish name, size/quantity, who it's for etc.


                //for each line of user input, make sure its correct numbers/type/etc

                //make Order object for each user input of an order, add to Queue

            //"kitchen making orders yay"


            //for loop: dequeues to "make" orders


            //print " heres your order (dish, quantity, name) yippiee"


            //"enjoy!"
        }
    }

    //2nd internal class Order - make one object for every order they make, store in Queue
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

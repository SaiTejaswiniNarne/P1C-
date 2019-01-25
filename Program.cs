using System;

namespace P1C_
{
    class Program
    {
        public static decimal totalCost(int numberofdrinks, decimal cc)
        {
            return numberofdrinks*cc;
        }
        static void Main(string[] args)
        {
            var name = String.Empty;
            var numberofdrinks = 0;
            var amount = 0.0m;
            var drink = "";
            var itemselection = 'i';
            var cost = 0.0;
            var EXIT = false;

            Console.WriteLine("Hello Welcome To Our Website!");

            while(name == "")
            {
                Console.WriteLine($"Enter your name: ");
                name = Console.ReadLine();
            }
            while(true){
            while(numberofdrinks == 0)
            {
                Console.WriteLine($"How many drinks do you need?");
                var ans = Console.ReadLine();
                numberofdrinks = Convert.ToInt32(ans);
            }
            Console.WriteLine($"You have selected {numberofdrinks} items.");

            if(numberofdrinks>6)
            {
                Console.WriteLine($"Sorry {name}, you can not buy more than 6 in this website.");
            }
            else{

            Console.WriteLine("Here is the Menu and select the drink you like:\na)Coke\nb)Dr Pepper\nc)Mountain Dew\nd)Pepsi\ne)Diet Coke\nf)Diet Pepsi");
            var itemselected = Console.ReadLine();
            itemselection = Convert.ToChar(itemselected);
            switch(itemselection){
                case 'a':   drink="Coke";
                            cost = 2.0; 
                            break;

                case 'b':   drink="Dr Pepper";
                            cost = 2.3;
                            break;

                case 'c':   drink="Mountain Dew";
                            cost = 2.1;
                            break;
            
                case 'd':   drink="Pepsi";
                            cost = 2.0;
                            break;

                case 'e':   drink="Diet Coke";
                            cost = 2.2;
                            break;

                case 'f':   drink="Diet Pepsi";
                            cost = 2.1;
                            break;

                default:    Console.WriteLine("Enter correct choice");
                            break;
            }
        var cc=Convert.ToDecimal(cost);
            amount = Program.totalCost(numberofdrinks, cc); 
            Console.WriteLine($"Your order is {drink} and the Cost of it is {amount}");
          }
        
        Console.WriteLine("Press q key to quit and any other key to continue...");
        var s = Console.ReadLine();
        if(s=="q")
        {
            EXIT = false;
            break;
        }  
        numberofdrinks=0;
            }  
        }
    }
}

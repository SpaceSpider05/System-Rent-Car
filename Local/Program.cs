using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            Console.WriteLine("enter your name: ");
              string  name = Console.ReadLine();
            Console.WriteLine($"Hello Mr'{name}");
            Console.WriteLine("Enter Your Age: ");
               int age = int.Parse( Console.ReadLine());

            if ( age >= 18 ) {
                Console.WriteLine("have you a driver liscence (y / n)");
                string response = ( Console.ReadLine());

                if ( response.Equals("y") )
                {
                    do
                    {

                  
                    Console.WriteLine("This is our cars:");
                    Console.WriteLine(" 1) dacia  250dh/day");
                    Console.WriteLine(" 2) renault 150dh/day");
                    Console.WriteLine(" 3) kia 200dh/day");
                    Console.WriteLine(" 4) bmw 500dh/day");
                    Console.WriteLine(" 5) ferrari 2200dh/day");


                        Console.WriteLine("wish car you want (1 / 2 / 3 / 4 / 5) :");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("how many day you need the car");
                        int day = Convert.ToInt32(Console.ReadLine());
                        int prix;
                        switch (choice)
                        {
                            
                            case 1: 
                                prix = day * 250;
                                break;
                            case 2:
                                prix = day * 150;
                                break;
                            case 3:
                                prix = day * 200; 
                                break;
                            case 4:
                                prix = day * 500;
                                break;
                            case 5:
                                prix = day * 2200;
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please enter a valid option.");
                                
                                return;
                        }
                      
                        Console.WriteLine($"the price is {prix} dh ");
                        Console.WriteLine("confirm your order : (y/n)");
                        string rep = Console.ReadLine();
                        if (rep.Equals("y"))
                        {
                            do
                            {
                                Console.WriteLine("your rent CONFIRMED \nlet your number here:");
                                int numberphone = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine($"SEE YOU LATER MR'{name} ");

                            }
                            while (rep.Equals("n"));
                        }
                        else if (rep == "n")
                        {

                        }
                        else
                        {
                            Console.WriteLine("something went wrong");
                        }
                    }
                    while (response.Equals("n") ) ;
                }
                else if (response.Equals( "n"))
                {
                        Console.WriteLine("sorry you are not allowed to rent a car");
                }
                else
                {
                    Console.WriteLine("Re Try");
                }
               
            }
            else
            {
               Console.WriteLine("sorry your under age ");
            }
           
        Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampResourcesCheckoutSystem
{
    class Program
    {
        static string[] menu = { "\n\t1. View Students", "\n\t2. View Available Resources", "\n\t3. View Student Accounts", "\n\t4. Checkout Item", "\n\t5. Return Item", "\n\t6. Exit" };
        static string[] students = { "Bob Jones", "Chad Lego", "Dale Earnie", "Jack Johnson", "Ricky Bobby" };
        static string[] resources = { "ASP.NET MVC5", "C# Players Guide", "Cracking the Tech Career", "Database Design for Mere Mortals", "Eloquent JavaScript", "Essential C#", "Head First C#", "Javascript for Kids", "Killer Game Programming in Java", "Problem Solving and Programming Design in C", "\n " };
        static string[] books = { "ASP.NET MVC5", "C# Players Guide", "Cracking the Tech Career", "Database Design for Mere Mortal", "Eloquent JavaScript", "Essential C#", "Head First C#", "Javascript for Kids", "Killer Game Programming in Java", "Problem Solving and Programming Design in C", "\n " };
        static string[] bobJones = { " ", " ", " " };
        static string[] chadLego = { " ", " ", " " };
        static string[] daleEarnie = { " ", " ", " " };
        static string[] jackJohnson = { " ", " ", " ", };
        static string[] rickyBobby = { " ", " ", " " };
        static void Menu()
        {

            Console.WriteLine("**********Hello welcome to: \"Bootcamp Resources Checkout System\"**********");
            Console.WriteLine("*****Please choose one of the following \"Menu Items\"*****");
            for ( int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine("\t" + menu[i]);
            }

            string optionMenu = Console.ReadLine().ToLower();
            switch (optionMenu)
            {
                case "1":
                case "view students":
                    Console.Clear();
                    StudentNames();
                    break;
                case "2":
                case "view available resources":
                    Console.Clear();
                    Available();
                    break;
                case "3":
                case "view student accounts":
                    Console.Clear();
                    Accounts();
                    break;
                case "4":
                case "checkout":
                    Console.Clear();
                    Checkout();
                    break;
                case "5":
                case "return":
                    Console.Clear();
                    Return();
                    break;
                case "6":
                case "exit":
                    Console.Clear();
                    Exit();
                    break;
                default:
                    Console.Clear();
                    Menu();
                    break;
            }

        }

        static void StudentNames()
        {

           for(int h = 0; h < students.Length; h++)
            {
                Console.WriteLine("\t\n\t" + students[h]);
            }

            Menu();

        }

        static void Available()
        {
            for ( int g = 0; g < resources.Length; g++)
            {
                Console.WriteLine("\t" + resources[g]);    
            }

           
            Menu();

        }

        static void Accounts()
        {

            bool flag1 = false;
            int a;
            Console.WriteLine("Enter your full name: ");
            string fullName = Console.ReadLine().ToLower();
            for (int m = 0; m < students.Length; m++)
            {
                if (fullName == students[m].ToLower())
                {
                    flag1 = true;
                    a = m;
                }

            }
            if (flag1 == false)
            {
                Console.WriteLine("Error: Request Unavailable");
            }
            if (fullName == students[0].ToLower())
            {
                if( string.IsNullOrWhiteSpace(bobJones[0]) && string.IsNullOrWhiteSpace(bobJones[1]) && string.IsNullOrWhiteSpace(bobJones[2]))
                {
                    Console.WriteLine("Nothing is checked out");
                }
                else
                {
                    Console.WriteLine(bobJones[0]);
                    Console.WriteLine(bobJones[1]);
                    Console.WriteLine(bobJones[2]);
                }
                
            }
            if (fullName == students[1].ToLower())
            {
                if (string.IsNullOrWhiteSpace(chadLego[0]) && string.IsNullOrWhiteSpace(chadLego[1]) && string.IsNullOrWhiteSpace(chadLego[2]))
                {
                    Console.WriteLine("Nothing is checked out");
                }
                else
                {
                    Console.WriteLine(chadLego[0]);
                    Console.WriteLine(chadLego[1]);
                    Console.WriteLine(chadLego[2]);
                }
                
            }
            if(fullName == students[2].ToLower())
            {
                if (string.IsNullOrWhiteSpace(daleEarnie[0]) && string.IsNullOrWhiteSpace(daleEarnie[1]) && string.IsNullOrWhiteSpace(daleEarnie[2]))
                {
                    Console.WriteLine("Nothing is checked out");
                }
                else
                {
                    Console.WriteLine(daleEarnie[0]);
                    Console.WriteLine(daleEarnie[1]);
                    Console.WriteLine(daleEarnie[2]);
                }
                
            }
            if (fullName == students[3].ToLower())
            {
                if (string.IsNullOrWhiteSpace(jackJohnson[0]) && string.IsNullOrWhiteSpace(jackJohnson[1]) && string.IsNullOrWhiteSpace(jackJohnson[2]))
                {
                    Console.WriteLine("Nothing is checked out");
                }
                else
                {
                    Console.WriteLine(jackJohnson[0]);
                    Console.WriteLine(jackJohnson[1]);
                    Console.WriteLine(jackJohnson[2]);
                }
                
            }
            if (fullName == students[4].ToLower())
            {
                if (string.IsNullOrWhiteSpace(rickyBobby[0]) && string.IsNullOrWhiteSpace(rickyBobby[1]) && string.IsNullOrWhiteSpace(rickyBobby[2]))
                {
                    Console.WriteLine("Nothing is checked out");
                }
                else
                {
                    Console.WriteLine(rickyBobby[0]);
                    Console.WriteLine(rickyBobby[1]);
                    Console.WriteLine(rickyBobby[2]);
                }
                
            }

            Menu(); 

        }

        static void Checkout()
        {
            string j = " ";
            bool flag1 = false;
            int a;
            Console.WriteLine("Enter your full name: ");
            string fullName = Console.ReadLine().ToLower();
            for (int m = 0; m < students.Length; m++)
            {
                if (fullName == students[m].ToLower())
                {
                    flag1 = true;
                    a = m;
                }
                    
            }
            if (flag1 == false)
            {
                Console.WriteLine("Error: Request Unavailable");
            }
            else
            {
                bool pole1 = false;
                int d = 1;
                Console.WriteLine("Enter title you want to check out: ");
                string bookOut = Console.ReadLine().ToLower();
                for (int m = 0; m < resources.Length; m++)
                {
                    if (bookOut == resources[m].ToLower())
                    {
                        pole1 = true;
                        d = m;
                    }
                        
                }
                if (pole1 == false)
                {
                    Console.WriteLine("Error: Request Unavailable");
                }
                if (fullName == students[0].ToLower())
                {
                    if (string.IsNullOrWhiteSpace(bobJones[0]))
                    {
                        bobJones[0] = resources[d];
                        Console.WriteLine(fullName + " checked out " + resources[d]);
                        resources[d] = j;
                    }
                    else if (string.IsNullOrWhiteSpace(bobJones[1]))
                    {
                        bobJones[1] = resources[d];
                        Console.WriteLine(fullName + " checked out " + resources[d]);
                        resources[d] = j;
                    }
                    else if (string.IsNullOrWhiteSpace(bobJones[2]))
                    {
                        bobJones[2] = resources[d];
                        Console.WriteLine(fullName + " checked out " + resources[d]);
                        resources[d] = j;
                    }
                    else if (!string.IsNullOrWhiteSpace(bobJones[0]) && !string.IsNullOrWhiteSpace(bobJones[1]) && !string.IsNullOrWhiteSpace(bobJones[2]))
                    {
                        Console.WriteLine(fullName + " has max number of books checked out.");
                    }                    
                }
                if (fullName == students[1].ToLower())
                {
                    if (string.IsNullOrWhiteSpace(chadLego[0]))
                    {
                        chadLego[0] = resources[d];
                        Console.WriteLine(fullName + " checked out " + resources[d]);
                        resources[d] = j;
                    }
                    else if (string.IsNullOrWhiteSpace(chadLego[1]))
                    {
                        chadLego[1] = resources[d];
                        Console.WriteLine(fullName + " checked out " + resources[d]);
                        resources[d] = j;
                    }
                    else if (string.IsNullOrWhiteSpace(chadLego[2]))
                    {
                        chadLego[2] = resources[d];
                        Console.WriteLine(fullName + " checked out " + resources[d]);
                        resources[d] = j;
                    }
                    else if (!string.IsNullOrWhiteSpace(chadLego[0]) && !string.IsNullOrWhiteSpace(chadLego[1]) && !string.IsNullOrWhiteSpace(chadLego[2]))
                    {
                        Console.WriteLine(fullName + " has max number of books checked out.");
                    }
                }
                if (fullName == students[2].ToLower())
                {
                    if (string.IsNullOrWhiteSpace(daleEarnie[0]))
                    {
                        daleEarnie[0] = resources[d];
                        Console.WriteLine(fullName + " checked out " + resources[d]);
                        resources[d] = j;
                    }
                    else if (string.IsNullOrWhiteSpace(daleEarnie[1]))
                    {
                        daleEarnie[1] = resources[d];
                        Console.WriteLine(fullName + " checked out " + resources[d]);
                        resources[d] = j;
                    }
                    else if (string.IsNullOrWhiteSpace(daleEarnie[2]))
                    {
                        daleEarnie[2] = resources[d];
                        Console.WriteLine(fullName + " checked out " + resources[d]);
                        resources[d] = j;
                    }
                    else if (!string.IsNullOrWhiteSpace(daleEarnie[0]) && !string.IsNullOrWhiteSpace(daleEarnie[1]) && !string.IsNullOrWhiteSpace(daleEarnie[2]))
                    {
                        Console.WriteLine(fullName + " has max number of books checked out.");
                    }
                }
                if (fullName == students[3].ToLower())
                {
                    if (string.IsNullOrWhiteSpace(jackJohnson[0]))
                    {
                        jackJohnson[0] = resources[d];
                        Console.WriteLine(fullName + " checked out " + resources[d]);
                        resources[d] = j;
                    }
                    else if (string.IsNullOrWhiteSpace(jackJohnson[1]))
                    {
                        jackJohnson[1] = resources[d];
                        Console.WriteLine(fullName + " checked out " + resources[d]);
                        resources[d] = j;
                    }
                    else if (string.IsNullOrWhiteSpace(jackJohnson[2]))
                    {
                        jackJohnson[2] = resources[d];
                        Console.WriteLine(fullName + " checked out " + resources[d]);
                        resources[d] = j;
                    }
                    else if (!string.IsNullOrWhiteSpace(jackJohnson[0]) && !string.IsNullOrWhiteSpace(jackJohnson[1]) && !string.IsNullOrWhiteSpace(jackJohnson[2]))
                    {
                        Console.WriteLine(fullName + " has max number of books checked out.");
                    }
                }
                if (fullName == students[4].ToLower())
                {
                    if (string.IsNullOrWhiteSpace(rickyBobby[0]))
                    {
                        rickyBobby[0] = resources[d];
                        Console.WriteLine(fullName + " checked out " + resources[d]);
                        resources[d] = j;
                    }
                    else if (string.IsNullOrWhiteSpace(rickyBobby[1]))
                    {
                        rickyBobby[1] = resources[d];
                        Console.WriteLine(fullName + " checked out " + resources[d]);
                        resources[d] = j;
                    }
                    else if (string.IsNullOrWhiteSpace(rickyBobby[2]))
                    {
                        rickyBobby[2] = resources[d];
                        Console.WriteLine(fullName + " checked out " + resources[d]);
                        resources[d] = j;
                    }
                    else if (!string.IsNullOrWhiteSpace(rickyBobby[0]) && !string.IsNullOrWhiteSpace(rickyBobby[1]) && !string.IsNullOrWhiteSpace(rickyBobby[2]))
                    {
                        Console.WriteLine(fullName + " has max number of books checked out.");
                    }
                }
            }
                
            Menu();
        }

        static void Return()
        {

            string j = " ";
            bool flag1 = false;
            int a;
            Console.WriteLine("Enter your full name: ");
            string fullName = Console.ReadLine().ToLower();
            for (int m = 0; m < students.Length; m++)
            {
                if (fullName == students[m].ToLower())
                {
                    flag1 = true;
                    a = m;
                }

            }
            if (flag1 == false)
            {
                Console.WriteLine("Error: Request Unavailable");
            }
            else
            {
                bool pole1 = false;
                int d = 1;
                Console.WriteLine("Enter title you want to return: ");
                string bookIn = Console.ReadLine().ToLower();
                for (int m = 0; m < bobJones.Length; m++)
                {
                    if (bookIn == bobJones[m].ToLower())
                    {
                        pole1 = true;
                        d = m;
                    }

                }
                if (pole1 == false)
                {
                    Console.WriteLine("Error: Request Unavailable");
                }
                if (fullName == students[0].ToLower())
                {
                    if (!string.IsNullOrWhiteSpace(bobJones[0]))
                    {
                        resources[d] = bobJones[0];
                        Console.WriteLine(fullName + " returned " + resources[d]);
                        j = resources[d];
                    }
                    else if (!string.IsNullOrWhiteSpace(bobJones[1]))
                    {
                        resources[d] = bobJones[1];
                        Console.WriteLine(fullName + " returned " + resources[d]);
                        j = resources[d];
                    }
                    else if (!string.IsNullOrWhiteSpace(bobJones[2]))
                    {
                        resources[d] = bobJones[2];
                        Console.WriteLine(fullName + " returned " + resources[d]);
                        j = resources[d];
                    }
                }
                for (int m = 0; m < chadLego.Length; m++)
                {
                    if (bookIn == chadLego[m].ToLower())
                    {
                        pole1 = true;
                        d = m;
                    }

                }
                if (pole1 == false)
                {
                    Console.WriteLine("Error: Request Unavailable");
                }
                if (fullName == students[1].ToLower())
                {
                    if (!string.IsNullOrWhiteSpace(chadLego[0]))
                    {
                        resources[d] = chadLego[0];
                        Console.WriteLine(fullName + " returned " + resources[d]);
                        j = resources[d];
                    }
                    else if (!string.IsNullOrWhiteSpace(chadLego[1]))
                    {
                        resources[d] = chadLego[1];
                        Console.WriteLine(fullName + " returned " + resources[d]);
                        j = resources[d];
                    }
                    else if (!string.IsNullOrWhiteSpace(chadLego[2]))
                    {
                        resources[d] = chadLego[2];
                        Console.WriteLine(fullName + " returned " + resources[d]);
                        j = resources[d];
                    }
                }
                for (int m = 0; m < daleEarnie.Length; m++)
                {
                    if (bookIn == daleEarnie[m].ToLower())
                    {
                        pole1 = true;
                        d = m;
                    }

                }
                if (pole1 == false)
                {
                    Console.WriteLine("Error: Request Unavailable");
                }
                if (fullName == students[2].ToLower())
                {
                    if (!string.IsNullOrWhiteSpace(daleEarnie[0]))
                    {
                        resources[d] = daleEarnie[0];
                        Console.WriteLine(fullName + " returned " + resources[d]);
                        j = resources[d];
                    }
                    else if (!string.IsNullOrWhiteSpace(daleEarnie[1]))
                    {
                        resources[d] = daleEarnie[1];
                        Console.WriteLine(fullName + " returned " + resources[d]);
                        j = resources[d];
                    }
                    else if (!string.IsNullOrWhiteSpace(daleEarnie[2]))
                    {
                        resources[d] = daleEarnie[2];
                        Console.WriteLine(fullName + " returned " + resources[d]);
                        j = resources[d];
                    }
                }
                for (int m = 0; m < jackJohnson.Length; m++)
                {
                    if (bookIn == jackJohnson[m].ToLower())
                    {
                        pole1 = true;
                        d = m;
                    }

                }
                if (pole1 == false)
                {
                    Console.WriteLine("Error: Request Unavailable");
                }
                if (fullName == students[3].ToLower())
                {
                    if (!string.IsNullOrWhiteSpace(jackJohnson[0]))
                    {
                        resources[d] = jackJohnson[0];
                        Console.WriteLine(fullName + " returned " + resources[d]);
                        j = resources[d];
                    }
                    else if (!string.IsNullOrWhiteSpace(jackJohnson[1]))
                    {
                        resources[d] = jackJohnson[1];
                        Console.WriteLine(fullName + " returned " + resources[d]);
                        j = resources[d];
                    }
                    else if (!string.IsNullOrWhiteSpace(jackJohnson[2]))
                    {
                        resources[d] = jackJohnson[2];
                        Console.WriteLine(fullName + " returned " + resources[d]);
                        j = resources[d];
                    }
                }
                for (int m = 0; m < rickyBobby.Length; m++)
                {
                    if (bookIn == rickyBobby[m].ToLower())
                    {
                        pole1 = true;
                        d = m;
                    }

                }
                if (pole1 == false)
                {
                    Console.WriteLine("Error: Request Unavailable");
                }
                if (fullName == students[4].ToLower())
                {
                    if (!string.IsNullOrWhiteSpace(rickyBobby[0]))
                    {
                        resources[d] = rickyBobby[0];
                        Console.WriteLine(fullName + " returned " + resources[d]);
                        j = resources[d];
                    }
                    else if (!string.IsNullOrWhiteSpace(rickyBobby[1]))
                    {
                        resources[d] = rickyBobby[1];
                        Console.WriteLine(fullName + " returned " + resources[d]);
                        j = resources[d];
                    }
                    else if (!string.IsNullOrWhiteSpace(bobJones[2]))
                    {
                        resources[d] = rickyBobby[2];
                        Console.WriteLine(fullName + " returned " + resources[d]);
                        j = resources[d];
                    }
                }
            }

            Array.Sort(resources);
            Menu();
        }
    

        static void Exit()
        {
            Console.WriteLine("Good-Bye");
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}

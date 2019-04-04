using System;

namespace Development_HRO
{
    public class DEV6A
    {
        public void init()
        {
            Algorithms algorithms = new Algorithms();
            Program program = new Program();
            bool exit = false;

            while (!exit)
            {
                System.Console.WriteLine("You selected the course DEV6A, This course is about algorithms");
                System.Console.WriteLine("Please choose your algorithm");
                Console.WriteLine("InsertionSort (i)");
                System.Console.WriteLine("Go back (b)");
                Console.WriteLine("Exit (e)");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "a":
                        algorithms.InstertionSort();
                        break;

                    case "b":
                        program.Restart();
                        break; 

                    case "e":
                        System.Console.WriteLine("Bye!");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("That is no option, Please try again"); 
                        break;
                }
            }
        }
        
    }

    public class Algorithms
    {
        public void InstertionSort(){

            

        }
    }
}
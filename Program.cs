using System;

namespace Development_HRO {
    public class Program {
        static void Main (string[] args) {

            StartApp ();
        }

        static void StartApp () {

            DEV6A d6a = new DEV6A ();
            DEV6B d6b = new DEV6B ();
            bool exit = false;

            while (!exit) {
                System.Console.WriteLine ("Welcome, here you can find info related to development");
                System.Console.WriteLine ("Please choose your course");
                Console.WriteLine ("DEV6A (a)");
                Console.WriteLine ("DEV6B (b)");
                Console.WriteLine ("Exit (e)");

                string menu = Console.ReadLine ();

                switch (menu) {
                    case "a":
                        d6a.init ();
                        break;

                    case "b":
                        d6b.init ();
                        break;

                    case "e":
                        System.Console.WriteLine ("Bye!");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine ("That is no option, Please try again");
                        break;
                }
            }
        }

    }
}
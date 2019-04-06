using System;

namespace Development_HRO {
    public class DEV6B {
        public void init () {

            bool exit = false;
            while (!exit) {
                Console.WriteLine ("You selected the course DEV6A, This course is about MapReduce and Neo4J");
                Console.WriteLine ("Please choose the subject");
                Console.WriteLine ("MapReduce (a)");
                Console.WriteLine ("Neo4J (b)");
                Console.WriteLine ("Go Back (z)");

                string menu = Console.ReadLine ();

                switch (menu) {
                    case "a":
                        System.Console.WriteLine ("\n");
                        break;

                    case "z":
                        System.Console.WriteLine ("Main menu");
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
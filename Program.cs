using System;
namespace Csharp_Algorithms {
    public class Program {
        static void Main (string[] args) {
            init();
        }

        private static void init () {
            Algorithms algorithms = new Algorithms ();
            PracAlgorithms pracAlgorithms = new PracAlgorithms ();

            //GENERATE NUMBERS
            int[] numberList = CreateNumberList (9);

            //CLI MENU 
            bool exit = false;
            while (!exit) {
                Console.WriteLine ("You selected the course DEV6A, This course is about algorithms");
                Console.WriteLine ("Please choose your algorithm");
                Console.WriteLine ("SequentialSearch (a)");
                Console.WriteLine ("BinarySearch (b)");
                Console.WriteLine ("InsertionSort (c)");
                Console.WriteLine ("BubbleSort (d)");
                Console.WriteLine ("MergeSort (e)");
                Console.WriteLine ("Go Back (z)");

                string menu = Console.ReadLine ();

                switch (menu) {
                    case "a":
                        Console.Clear ();
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine ("Sequential search found the input number " + algorithms.SequentialSearch (numberList));
                        Console.ResetColor ();
                        System.Console.WriteLine ("\n");
                        break;

                    case "b":
                        Console.Clear ();
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine ("Binary search found the input number at position " + algorithms.BinarySearch (numberList));
                        Console.ResetColor ();
                        System.Console.WriteLine ("\n");
                        break;

                    case "c":
                        PrintIntegerArray (algorithms.InsertionSort (numberList));
                        break;

                    case "d":
                        PrintIntegerArray (algorithms.BubbleSort (numberList));
                        break;

                    case "e":
                        PrintIntegerArray (algorithms.MergeSort (numberList, 0, numberList.Length - 1));
                        break;

                    case "z":
                        Console.Clear ();
                        System.Console.WriteLine ("Main menu");
                        exit = true;
                        break;

                    default:
                        Console.Clear ();
                        Console.WriteLine ("That is no option, Please try again");
                        break;
                }
            }
        }

        static int[] CreateNumberList (int listSize) {
            int Min = 0;
            int Max = 20;
            int[] list = new int[listSize];

            Random randNum = new Random ();
            for (int i = 0; i < list.Length; i++) {
                list[i] = randNum.Next (Min, Max);
            }
            return list;
        }

        static void PrintIntegerArray (int[] array) {
            Console.Clear ();
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine ("Sorting algorithm outcome: ");
            foreach (int i in array) {
                Console.Write (i.ToString () + "  ");
            }
            System.Console.WriteLine ("\n");
            Console.ResetColor ();
        }

    }
}
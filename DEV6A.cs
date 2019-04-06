using System;
using System.Collections.Generic;

namespace Development_HRO {
    public class DEV6A {
        public void init () {
            Algorithms algorithms = new Algorithms ();
            Program program = new Program ();
            bool exit = false;
            int[] numberList = CreateNumberList (9);

            while (!exit) {
                Console.WriteLine ("You selected the course DEV6A, This course is about algorithms");
                Console.WriteLine ("Please choose your algorithm");
                Console.WriteLine ("SequentialSearch (a)");
                Console.WriteLine ("BinarySearch (b)");
                Console.WriteLine ("InsertionSort (c)");
                Console.WriteLine ("Go Back (z)");

                string menu = Console.ReadLine ();

                switch (menu) {
                    case "a":
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine ("Sequential search found the input number " + algorithms.SequentialSearch (numberList));
                        Console.ResetColor ();
                        System.Console.WriteLine ("\n");
                        break;

                    case "b":
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine ("Binary search found the input number at position " + algorithms.BinarySearch (numberList));
                        Console.ResetColor ();
                        System.Console.WriteLine ("\n");
                        break;

                    case "c":
                        System.Console.WriteLine ("Binary search found the input number at position " + algorithms.BinarySearch (numberList));
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
            foreach (int i in array) {
                Console.Write (i.ToString () + "  ");
            }
            System.Console.WriteLine ("\n");
        }

    }

    public class Algorithms {
        public int SequentialSearch (int[] array) {
            System.Console.WriteLine ("Please fill in the number you want to find, it will return -1 if number is not found");
            int input = Convert.ToInt32 (Console.ReadLine ());
            for (int i = 0; i < array.Length; i++) {
                if (array[i] == input) {
                    return array[i];
                }
            }
            return -1;
        }

        public int BinarySearch (int[] array) {
            System.Console.WriteLine ("Please fill in the number you want to find, it will return -1 if number is not found");
            int input = Convert.ToInt32 (Console.ReadLine ());
            var low = 0;
            var high = array.Length - 1;

            while (low <= high) {
                var middle = (low + high) / 2;
                if (input < array[middle]) {
                    high = middle - 1;
                } else if (input > array[middle]) {
                    low = middle + 1;
                } else {
                    return middle;
                }
            }
            return -1;
        }
    }
}
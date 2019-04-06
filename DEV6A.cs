using System;

namespace Development_HRO {
    public class DEV6A {
        public void init () {
            Algorithms algorithms = new Algorithms ();
            Program program = new Program ();
            bool exit = false;

            while (!exit) {
                Console.WriteLine ("You selected the course DEV6A, This course is about algorithms");
                Console.WriteLine ("Please choose your algorithm");
                Console.WriteLine ("SequentialSearch (a)");
                Console.WriteLine ("BinarySearch (b)");
                Console.WriteLine ("Go Back (z)");

                int[] numberListSearch = { 1, 4, 7, 9, 10, 80 };
                int[] numberListOrder = { 8, 6, 2, 9, 4, 2, 9, 1, 15, 7 };

                string menu = Console.ReadLine ();

                switch (menu) {
                    case "a":
                        System.Console.WriteLine ("Sequential search found the input number " + algorithms.SequentialSearch(numberListSearch));
                        System.Console.WriteLine ("\n");
                        break;

                    case "b":
                        System.Console.WriteLine ("Binary search found the input number at position " + algorithms.BinarySearch(numberListSearch));
                        System.Console.WriteLine ("\n");
                        break;
                    case "z":
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
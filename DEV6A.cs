﻿using System;
using System.Collections.Generic;
using Tester;

namespace Development_HRO {
    public class DEV6A {
        public void init () {
            Algorithms algorithms = new Algorithms ();
            int[] numberList = CreateNumberList (9);

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

    public class Algorithms {

        //SEARCHING ALGROTIHMS
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


        //SORTING ALGORITHMS
        public int[] InsertionSort (int[] array) {
            for (int i = 0; i < array.Length; i++) {
                var key = array[i];
                var j = i - 1;

                while (j >= 0 && array[j] > key) {
                    array[j + 1] = array[j]; // adding the number to the next place in the list
                    j = j - 1; // going to the next element
                }
                array[j + 1] = key;
            }
            return array;
        }

        public int[] BubbleSort (int[] array) {
            var somethingChanged = true;
            while (somethingChanged) {
                somethingChanged = false;
                for (int i = 0; i < array.Length - 1; i++) {
                    if (array[i].CompareTo (array[i + 1]) > 0) {
                        var temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;

                        somethingChanged = true;
                    }
                }
            }
            return array;
        }
        public int[] MergeSort (int[] arr, int leftBoundary, int rightBoundary) {
            if (leftBoundary < rightBoundary) {
                int middle = (leftBoundary + rightBoundary) / 2;

                MergeSort (arr, leftBoundary, middle);
                MergeSort (arr, middle + 1, rightBoundary);
                return Sorting<int>.Merge (arr, leftBoundary, middle, rightBoundary);

            }
            return null;
        }

        //LINKED LIST ALGORITHMS
        public Node<int> SortedListFind (SortedLinkedList<int> list, int value) {
            var curr = list.start;

            while (curr.Value != value) {
                if (curr.Value > value)
                    return null;

                curr = curr.Next;
            }

            return curr;
        }

        public void SortedListAdd (SortedLinkedList<int> list, int value) {
            if (list.start == null || list.start.Value.CompareTo (value) >= 0) {
                // TODO: EX 1.1 list.start = ?
                list.start = new Node<int> (value, list.start);
                return;
            }

            Node<int> curr = list.start;
            while (curr.Next != null && curr.Next.Value.CompareTo (value) < 0) {

                // TODO: EX 1.2 PLACEHOLDER, REPLACE break WITH YOUR CODE 
                curr = curr.Next;

            }
            curr.Next = new Node<int> (value, curr.Next);
            // TODO: EX 1.3 curr.Next = ?
        }

        //HAS TO BE DONE
        public void SortedListDelete (SortedLinkedList<int> list, int value) {

        }


        //HASHTABLE ALGORITHMS
        static int getIndex (string key, int size) {
            int hashCode = Math.Abs (key.GetHashCode ());
            int index = hashCode % size;
            return index;
        }
        static Nullable<int> HashTableFind (HashTable<string, int> table, string key) {
            var arraySize = table.buckets.Length;
            int index = getIndex (key, arraySize);
            var values = table.buckets;
            if (values[index] == null)
                return null;
            else {
                if (values[index].Key.Equals (key)) {
                    return values[index].Value;
                } else {
                    // TODO: Ex2.1; potentialIndex = ?
                    var potentialIndex = index; // PLACEHOLDER: REMOVE AND REPLACE WITH YOUR CODE

                    while (values[potentialIndex] != null) {
                        if (values[potentialIndex].Key.Equals (key)) {
                            return values[potentialIndex].Value;
                        }

                        potentialIndex++;
                        if (potentialIndex >= arraySize)
                            potentialIndex = 0;
                        if (potentialIndex == index)
                            return null;
                    }
                }
            }
            return null;
        }
        static void HashTableAdd (HashTable<string, int> table, string key, int value) {
            var arraySize = table.buckets.Length;
            int index = getIndex (key, arraySize);
            var values = table.buckets;
            if (values[index] == null)
                values[index] = new Entry<string, int> (key, value); //TODO: Ex 2.2 PLACEHOLDER: REPLACE null WITH YOUR CODE
            else {
                if (values[index].Key.Equals (key)) {
                    throw new ArgumentException ("Key already exists");
                } else {
                    // TODO: Ex2.3; potentialIndex = ?
                    var potentialIndex = index; // PLACEHOLDER: REMOVE AND REPLACE WITH YOUR CODE

                    while (values[potentialIndex] != null) {
                        potentialIndex++;
                        if (potentialIndex >= arraySize)
                            potentialIndex = 0;
                        if (potentialIndex == index)
                            return;
                    }
                    values[potentialIndex] = new Entry<string, int> (key, value); //TODO: Ex 2.4 PLACEHOLDER: REPLACE null WITH YOUR CODE
                }
            }
        }

        static void HashTableDelete (HashTable<string, int> table, string key) {
            var arraySize = table.buckets.Length;
            int index = getIndex (key, arraySize);
            var values = table.buckets;
            if (values[index] == null)
                return;
            else {
                if (values[index].Key.Equals (key)) {
                    //TODO: EX 3.1 values[index] = ?;
                    values[index] = null;
                } else {
                    var potentialIndex = getIndex (key, arraySize); //TODO: EX 3.2 PLACEHOLDER, REPLACE 0 WITH YOUR CODE
                    while (values[potentialIndex] != null) {
                        if (values[potentialIndex].Key.Equals (key)) {
                            //TODO: EX 3.3 values[potentialIndex] = ?;
                            values[potentialIndex] = null;
                            return;
                        }

                        potentialIndex++;
                        if (potentialIndex >= arraySize)
                            potentialIndex = 0;
                        if (potentialIndex == index)
                            return;
                    }
                }
            }
        }


        //BINARY SEARCH TREE ALGORITHMS
        static TreeNode<int> BSTFind (BSTree<int> tree, int value) {
            return searchStartingFrom (tree.root, value); // TODO: Ex 4.1 PLACEHOLDER: REPLACE null WITH YOUR CODE
        }

        private static TreeNode<int> searchStartingFrom (TreeNode<int> node, int value) {
            if (node == null)
                throw new Exception ("value not found");

            if (node.value.CompareTo (value) == 0)
                return node; // TODO: Ex 4.2 PLACEHOLDER: REPLACE null WITH YOUR CODE

            if (node.value.CompareTo (value) < 0)
                return searchStartingFrom (node.rightChild, value); // TODO: Ex 4.3 PLACEHOLDER: REPLACE null WITH YOUR CODE

            return searchStartingFrom (node.leftChild, value); // TODO: Ex 4.4 PLACEHOLDER: REPLACE null WITH YOUR CODE
        }
        static void BSTAdd (BSTree<int> tree, int value) {
            if (tree.root == null) {
                // TODO: EX4.1; tree.root = ?
                tree.root = new TreeNode<int> (value, tree.root, null, null);
                return;
            } else
                // TODO: Ex4.2
                BSTInsertStartingFrom (tree.root, value); // PLACEHOLDER; REMOVE AND REPLACE WITH YOUR CODE
        }

        static void BSTInsertStartingFrom (TreeNode<int> node, int value) {
            if (node.value.CompareTo (value) < 0) {
                if (node.rightChild == null) {
                    // TODO: Ex4.3; node.rightChild = ?
                    node.rightChild = new TreeNode<int> (value, node, null, null);
                } else {
                    // TODO: Ex4.4
                    BSTInsertStartingFrom (node.rightChild, value);
                }
            } else if (node.value.CompareTo (value) > 0) {
                if (node.leftChild == null) {
                    // TODO: Ex4.5; node.leftChild = ?
                    node.leftChild = new TreeNode<int> (value, node, null, null);
                } else {
                    // TODO: Ex4.6
                    BSTInsertStartingFrom (node.leftChild, value);
                }
            }
        }

        //HAS TO BE DONE
        public void BSTDelete () {

        }

        public void Stack(){

        }

        public void Queue(){
            
        }
    }

}
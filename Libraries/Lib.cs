using System;

namespace Development_HRO.Libraries {
    public class HashTable<K, V> where K : IComparable {
        public HashTable (int capacity) { var cap = capacity;}

        public Entry<K, V>[] buckets { get; }
    }

    public class Entry<K, V>
    {
        public Entry(K key, V value){}

        public K Key { get; set; }
        public V Value { get; set; }
    }

    public class SortedLinkedList<T> where T : IComparable
    {
        public Node<T> start;

        public override string ToString(){return null;}
    }

    public class Node<T> where T : IComparable
    {
        public Node(T value, Node<T> next){}

        public T Value { get; }
        public Node<T> Next { get; set; }
    }


    public class TreeNode<T> where T : IComparable
    {
        public TreeNode<T> parent;
        public TreeNode<T> leftChild;
        public TreeNode<T> rightChild;

        public TreeNode(T value, TreeNode<T> parent, TreeNode<T> left, TreeNode<T> right){}

        public T value { get; set; }
    }

    public class BSTree<T> where T : IComparable
    {
        public TreeNode<T> root { get; set; }

        public static TreeNode<T> findInOrderSucc(TreeNode<T> node){return null;}
        public static bool isLeftChild(TreeNode<T> node, TreeNode<T> parent){return true;}
    }

    public static class Sorting<T> where T : IComparable
    {
        public static T[] Merge(T[] arr, int left, int middle, int right){return null;}
    }
}
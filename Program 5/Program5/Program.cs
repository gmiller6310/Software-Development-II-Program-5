// Grading ID: C6485
// Course: CIS200-01
// Program: 5
// Due: December 5, 2017 11:59 PM
// Description: Explores the use of binary search trees and generic classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    // Contains the test data for the TreeNode class

    // class TreeNode declaration
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 8, 2, 4, 3, 1, 7, 5, 6, 9, 10 };
            double[] doubleArray = { 8.8, 2.2, 4.4, 3.3, 1.1, 7.7, 5.5, 6.6, 9.9, 10.10};
            string[] stringArray =
               {"eight", "two", "four","three", "one", "seven", "five", "six", "nine", "ten"};

            // create int Tree
            Tree<int> intTree = new Tree<int>();
            PopulateIntTree(intArray, intTree, nameof(intTree));
            TraverseTree(intTree, nameof(intTree));

            // create double Tree
            Tree<double> doubleTree = new Tree<double>();
            PopulateDoubleTree(doubleArray, doubleTree, nameof(doubleTree));
            TraverseTree(doubleTree, nameof(doubleTree));

            // create string Tree
            Tree<string> stringTree = new Tree<string>();
            PopulateStringTree(stringArray, stringTree, nameof(stringTree));
            TraverseTree(stringTree, nameof(stringTree));
        }

        // populate Tree with array elements
        private static void PopulateIntTree(Array array, Tree<int> tree, string name)
        {
            Console.WriteLine($"\n\n\nInserting into {name}:");

            foreach (int data in array)
            {
                Console.Write($"{data} ");
                tree.InsertNode(data);
            }
        }

        private static void PopulateDoubleTree(Array array, Tree<double> tree, string name)
        {
            Console.WriteLine($"\n\n\nInserting into {name}:");

            foreach (double data in array)
            {
                Console.Write($"{data} ");
                tree.InsertNode(data);
            }
        }

        private static void PopulateStringTree(Array array, Tree<string> tree, string name)
        {
            Console.WriteLine($"\n\n\nInserting into {name}:");

            foreach (string data in array)
            {
                Console.Write($"{data} ");
                tree.InsertNode(data);
            }
        }

        // perform traversals
        private static void TraverseTree(Tree<int> tree, string treeType)
        {
            // perform inorder traversal of tree
            Console.WriteLine($"\n\nInorder traversal of {treeType}");
            tree.InorderTraversal();
        }

        private static void TraverseDoubleTree(Tree<double> tree, string treeType)
        {
            // perform inorder traversal of tree
            Console.WriteLine($"\n\nInorder traversal of {treeType}");
            tree.InorderTraversal();
        }

        private static void TraverseStringTree(Tree<string> tree, string treeType)
        {
            // perform inorder traversal of tree
            Console.WriteLine($"\n\nInorder traversal of {treeType}");
            tree.InorderTraversal();
        }



    }
    
}

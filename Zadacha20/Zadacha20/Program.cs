using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha20
{
    public class BinarySearchTree<T>
        where T : IComparable<T>
    {
        private class BinaryTreeNode<T> :
            IComparable<BinaryTreeNode<T>>
            where T : IComparable<T>
        {
            internal T value;
            internal BinaryTreeNode<T> parent;
            internal BinaryTreeNode<T> leftChild;
            internal BinaryTreeNode<T> rightChild;

            public BinaryTreeNode(T value)
            {
                this.value = value;
                this.parent = null;
                this.leftChild = null;
                this.rightChild = null;
            }

            public override string ToString()
            {
                return this.value.ToString();
            }

            public override int GetHashCode()
            {
                return this.value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                BinaryTreeNode<T> other = (BinaryTreeNode<T>)obj;
                return this.CompareTo(other) == 0;
            }

            public int CompareTo(BinaryTreeNode<T> other)
            {
                return this.value.CompareTo(other.value);
            }
        }
        private BinaryTreeNode<T> root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        public void Insert(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Невалидна стойност!");
            }

            this.root = Insert(value, null, root);
        }

        private BinaryTreeNode<T> Insert(T value, BinaryTreeNode<T> parentNode, BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                node = new BinaryTreeNode<T>(value);
                node.parent = parentNode;
            }
            else
            {
                int compareTo = value.CompareTo(node.value);
                if (compareTo < 0)
                {
                    node.leftChild = Insert(value, node, node.leftChild);
                }
                else if (compareTo > 0)
                {
                    node.rightChild = Insert(value, node, node.rightChild);
                }
            }
            return node;
        }
        
        private T MinVal(BinaryTreeNode<T> node)
        {
            BinaryTreeNode<T> current = node;
            while (current.leftChild != null)
            {
                current = current.leftChild;
            }
            return (current.value);
        }

        public T MinVal()
        {
            T data1;
            data1 = MinVal(this.root);
            return data1;
        }

        private T MaxVal(BinaryTreeNode<T> node)
        {
            BinaryTreeNode<T> current = node;
            while (current.rightChild != null)
            {
                current = current.rightChild;
            }
            return (current.value);
        }

        public T MaxVal()
        {
            T data2;
            data2 = MaxVal(this.root);
            return data2;
        }

        private void PrintTree(BinaryTreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }

            PrintTree(root.leftChild);
            Console.Write(" ");
            Console.Write(root.value);
            Console.Write(" ");
            PrintTree(root.rightChild);
        }

        public void PrintTree()
        {
            PrintTree(this.root);
            Console.WriteLine();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int count, input, min, max;
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            Console.Write("Въведете броя на елементите на дървото: ");
            count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                input = int.Parse(Console.ReadLine());
                binarySearchTree.Insert(input);
            }
            min = binarySearchTree.MinVal();
            max = binarySearchTree.MaxVal();
            Console.WriteLine("Минималния елемент на двоичното търсене е {0}.", min);
            Console.WriteLine("Максималния елемент на двоичното търсене е {0}.", max);
            Console.WriteLine("Елементите на двоичното дърво са: ");
            binarySearchTree.PrintTree();
            Console.ReadKey();
        }
    }
}

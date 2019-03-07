using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainNodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Node firstNode = new Node() { Value = 1, Next = null };
            Node secondNode = new Node() { Value = 2, Next = null };
            Node thirdNode = new Node() { Value = 3, Next = null };
            Node lastNode = new Node() { Value = 4, Next = null };

            firstNode.Next = secondNode;
            secondNode.Next = thirdNode;
            thirdNode.Next = lastNode;
            PrintNode(firstNode);
            Console.ReadLine();

        }

        public static void PrintNode(Node node)
        {
            while (node!=null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}

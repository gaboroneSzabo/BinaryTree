using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHeight
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bogyo root = new Bogyo(0);
            BaszoTree tree = new BaszoTree(root);
            tree.Add(10);
            tree.Add(1);
            tree.Add(15);
            tree.Add(16);
            tree.Add(111);
            tree.Add(4);
            Console.WriteLine(tree.CheckRecursive(root, 16));
            Console.ReadKey();
        }
    }
}

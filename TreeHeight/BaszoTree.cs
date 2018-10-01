using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHeight
{
    public class BaszoTree
    {
        Bogyo root;

        public BaszoTree(Bogyo root)
        {
            this.root = root;
        }

        public int GetDepth()
        {
            return 0;
        }
        
        public void Add(int cucc)
        {
            root.Recursive(root, cucc);
            Console.WriteLine(root.Value);
        }
       

        public bool CheckRecursive(Bogyo bogyo, int cucc)
        {
            if(bogyo!=null)
            {
                
                if(root.Value == cucc)
                {
                    return true;
                } else
                {
                    if(CheckRecursive(bogyo.Left, cucc))
                    {
                        return true;
                    }
                    if(CheckRecursive(bogyo.Right, cucc))
                    {
                        return true;
                    }
                    
                }
                
            }
            return false;
        }
    }
}

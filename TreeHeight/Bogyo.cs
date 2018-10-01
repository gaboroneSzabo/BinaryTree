using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHeight
{
    public class Bogyo
    {
        int value;
        Bogyo left;
        Bogyo right;

        public Bogyo(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }

        public int Value { get; set; }
        public Bogyo Left { get; set; }
        public Bogyo Right { get; set; }

        public Bogyo Recursive(Bogyo bogyo, int value)
        {
            if(bogyo == null)
            {
                return new Bogyo(value);
            }
            else if(value >= bogyo.Value){
                return Recursive(bogyo.right, value);
            } else if(value < bogyo.value)
            {
                return Recursive(bogyo.left, value);
            }
        }
    }
}

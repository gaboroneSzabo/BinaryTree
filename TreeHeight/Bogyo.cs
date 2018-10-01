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
        }

        public int Value { get; set; }
        public Bogyo Left { get; set; }
        public Bogyo Right { get; set; }
    }
}

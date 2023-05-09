using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Numbers
    {
        public int myFunc(int num)
        {
            return num / 12;
        }

        public int myFunc(decimal num)
        {
            int newnum = Convert.ToInt32(num);
            return newnum + 3;
        }

        public int myFunc(string num)
        {
            int newnum = Convert.ToInt32(num);
            return newnum + 7;
        }
    }
}

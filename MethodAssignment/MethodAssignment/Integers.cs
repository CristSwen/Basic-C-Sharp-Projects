﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class Integers
    {
        public int IntMethod(int num1, int num2 = 1)
        {
            int newnum = num1 * 3 + num2;
            return newnum;
        }
    }
}

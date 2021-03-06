﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplier
{
    public class Multiplier
    {
        public long Simple(long l1, long l2)
        {
            return l1 * l2;
        }

        public long ForLoop(int a)
        {
            int total = 0;
            for (int i = 0; i < a; i++)
            {
                total += i;
            }

            return total;
        }

        public long While(long left, long right) {
            long total = 0;
            long loopVar = 0;

            while (loopVar < left)
            {
                total += right;
                loopVar++;
            }
            return total;
        }

        static void Main(string[] args)
        {

        }
    }
}

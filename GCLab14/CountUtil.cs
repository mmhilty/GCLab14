using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab14
{
    class CountUtil
    {

        public void Count(ICountable c, int MaxCount)
        {
            Console.WriteLine($"Counting {c.GetType().Name}s:\n");
            for (int i = 0; i < MaxCount; i++)
            {
                c.IncrementCount();
                Console.WriteLine($"{c.GetCount()}. {c.ReturnName()}");
            }
            c.ResetCount();
            Console.WriteLine("");
        }
    }
}

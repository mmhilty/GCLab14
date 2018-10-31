using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab14
{
    class Alligator : ICountable
    {
        private int incrCount = 0;
        private string Name = "Ali the Alligator";

        public String ReturnName()
        {
            return Name;
        }
        public void IncrementCount()
        {
            incrCount++;
        }
        public void ResetCount()
        {
            incrCount = 0;
        }
        public int GetCount()
        {
            return incrCount;
        }
        public String GetCountString()
        {
            return ($"{GetCount()}");
        }

    }
}

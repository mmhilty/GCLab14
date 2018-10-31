using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab14
{
    interface ICountable
    {
        String ReturnName();
        void IncrementCount();
        void ResetCount();
        int GetCount();
        String GetCountString();
    }
}

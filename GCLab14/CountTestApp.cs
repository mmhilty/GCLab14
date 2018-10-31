using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab14
{
    class CountTestApp
    {
        public static void CountMethod()
        {
            CountUtil cu = new CountUtil();
            Alligator Gator = new Alligator();
            cu.Count(Gator, 3);

            Sheep Woolington = new Sheep("Woolington the 3rd");
            cu.Count(Woolington, 2);

            Sheep NewSheep = (Sheep)(Woolington.Clone());
            cu.Count(NewSheep, 3);

            cu.Count(Woolington, 1);
        }
    }
}

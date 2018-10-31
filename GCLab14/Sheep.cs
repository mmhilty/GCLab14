using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GCLab14
{
    class Sheep : ICloneable , ICountable
    {

        private String Name;
        private int incrCount = 0;

        public Sheep(string Name)
        {
            this.Name = Name;
        }
        public void ChangeName()
        {
            Console.WriteLine("What's the new name?");
            Name = Console.ReadLine();
        }
        public String ReturnName()
        {
            return Name;
        }

        ///////////
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
        //////////////

        public object Clone()
        {
            Console.WriteLine("What's the new sheep name?");
            String Name = Console.ReadLine();
            Console.WriteLine();
            Sheep newSheep = new Sheep(Name);
            return newSheep;
        }




    }
}

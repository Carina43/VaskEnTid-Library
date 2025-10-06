using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaskEnTidLibrary.Model
{
    public class Dryer : Machine
    {
        public Dryer(int id, int laundromatID) : base(id, laundromatID) 
        {
            Type = MachineType.Tørretumbler;
        }
    }
}

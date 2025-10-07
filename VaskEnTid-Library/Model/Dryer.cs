using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaskEnTidLibrary.Model
{
    public class Dryer : Machine
    {
        public Dryer(int machineID, int laundromatID) : base(machineID, laundromatID) 
        {
            Type = MachineType.Tørretumbler;
        }
    }
}

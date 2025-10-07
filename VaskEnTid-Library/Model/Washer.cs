using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaskEnTidLibrary.Model
{
    public class Washer : Machine
    {
        public Washer (int machineID, int laundromatID) : base(machineID, laundromatID)
        {
            Type = MachineType.Vaskemaskine;
        }
    }
}

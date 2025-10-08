using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaskEnTidLibrary.Model
{
    public abstract class Machine
    {
        public enum MachineType { Vaskemaskine, Tørretumbler, Rullemaskine }

        private int _machineID;
        private int _luandromatID;
        private MachineType _machineType;

        public int MachineID { get { return _machineID; } set { _machineID = value; } }
        public int LaundromatID { get { return _luandromatID; } set { _luandromatID = value; } }
        public MachineType Type { get { return _machineType; } set { _machineType = value; } }

        public Machine(int machineID, int laundromatID)
        {
            MachineID = machineID;
            LaundromatID = laundromatID;
        }
    }
}

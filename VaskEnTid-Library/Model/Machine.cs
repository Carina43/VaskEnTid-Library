using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaskEnTidLibrary.Model
{
    public abstract class Machine
    {
        internal enum MachineType { Vaskemaskine, Tørretumbler, Rullemaskine }

        private int _machineID;
        private int _luandromatID;
        private MachineType _machineType;

        internal int MachineID { get { return _machineID; } set { _machineID = value; } }
        internal int LaundromatID { get { return _luandromatID; } set { _luandromatID = value; } }
        internal MachineType Type { get { return _machineType; } set { _machineType = value; } }

        public Machine(int id, int laundromatID)
        {
            MachineID = id;
            LaundromatID = laundromatID;
        }
    }
}

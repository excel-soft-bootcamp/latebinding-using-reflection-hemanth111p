using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySolution
{
    public delegate void DoorStatus(string status);
    
    class DoorSensor
    {
        string status;
        string time;
        public event DoorStatus StatusChanged;
        public void Open()
        {
            status = "door open";
           
            StatusChanged.Invoke(this.status);
        }
        public void Close()
        {
            status = "door closed";
            StatusChanged.Invoke(this.status);
        }
    }
}

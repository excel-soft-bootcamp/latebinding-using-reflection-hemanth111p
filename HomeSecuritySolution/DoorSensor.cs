using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySolution
{
    public delegate void DoorStatusHandler(string status);
    
    class DoorSensor
    {
        string status;
        
        public event DoorStatusHandler OnDoorStatusChanged;
        public void Open()
        {
            status = "Opened";
            this.Notify();
           
           
        }
        public void Close()
        {
            status="Closed";
            this.Notify();
            
        }
        void Notify(){
        string =message $"{this.status} and Time : {System.DateTime.Now.ToString()}";   
        OnDoorStatusChanged.Invoke(status);
        }
    }
}

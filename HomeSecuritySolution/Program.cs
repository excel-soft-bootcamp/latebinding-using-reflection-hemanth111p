using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SecuritySystem _securitySystem = new SecuritySystem();
            DoorStatusHandler doorStatusChangeHandler = new DoorStatusHandler(_securitySystem.Notify);


            DoorSensor doorSensor = new DoorSensor();
            doorSensor.OnDoorStatusChanged += doorStatusChangeHandler;
            doorSensor.Open();
            doorSensor.Close();


           
            
        }
    }
}

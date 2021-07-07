using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public class ConsoleUserChoice
    {
        public Options  UserInput()
        {
            string displayMessage = $"Enter Your Choice {(int)Options.BASIC}->Basic,{(int)Options.INTERMEDIATE}->Intermediate,{(int)Options.ADVANCED}->Advanced";
            Console.WriteLine(displayMessage);
                Options _choice = (Options)Int32.Parse(Console.ReadLine());                      
            return _choice;
        }


}
}

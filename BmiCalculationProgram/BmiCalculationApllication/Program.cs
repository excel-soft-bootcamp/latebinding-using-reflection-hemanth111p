using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculationApllication
{
    public enum Options
    {
        CONSOLEINPUT = 1, FILEINPUT
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            int repeatableCount = 3;
            do
            {
                string displayMessage = $"Enter Your Choice {(int)Options.CONSOLEINPUT}->ConsoleInput,{(int)Options.FILEINPUT}->FileInput";
                ConsoleMessageDisplayLib.ConsoleMessageDisplayType.Display(displayMessage);
                try
                {
                    Options _choice = (Options)Int32.Parse(Console.ReadLine());
                    if ((int)_choice < 1 || (int)_choice > 2)
                    {
                        ConsoleMessageDisplayLib.ConsoleMessageDisplayType.Display("invalid input");
                    }
                    else
                    {
                        switch (_choice)
                        {
                            case Options.CONSOLEINPUT:
                                ConsolePatientDataReader.consoleReader();
                                break;
                            case Options.FILEINPUT:
                                PatientDetailsFromFile.FileInput();
                                break;
                        }
                        break;
                    }
                   
                }
                catch(FormatException e)
                {
                    ConsoleMessageDisplayLib.ConsoleMessageDisplayType.Display("choice must be a number");

                }
                --repeatableCount;
            } while (repeatableCount > 0);

            
        }
        
    }
}

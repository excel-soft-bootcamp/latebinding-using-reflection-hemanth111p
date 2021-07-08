using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculationApllication
{
    public static class ConsolePatientDataReader
    {
        public static void consoleReader()
        {
            int height = UserInputReadFromConsoleLib.UserInputReadFromConsoleType.GetUserHeight();
            int weight = UserInputReadFromConsoleLib.UserInputReadFromConsoleType.GetUserWeight();

            int bmiValue = BmiValueCalculationLib.BmiValueCalculationType.Calculator(height, weight);

            string message = BmiValueValidatorLib.BmiValueValidatorType.CheckCondition(bmiValue);

            ConsoleMessageDisplayLib.ConsoleMessageDisplayType.Display(message);
        }
    }
}


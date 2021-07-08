using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    //Named Constants
    //Constant Value is - int
    public enum Options
    {
        BASIC=1,INTERMEDIATE,ADVANCED
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Word Guess Game");
            ConsoleUserChoice consoleUser = new ConsoleUserChoice();
            consoleUser.ReadUserInput();
            

        }
    }
}

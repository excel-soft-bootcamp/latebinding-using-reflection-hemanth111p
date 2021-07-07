using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public enum Options
    {
        BASIC = 1, INTERMEDIATE, ADVANCED
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Word Guess Game");
          
            ConsoleUserChoice userChoice = new ConsoleUserChoice();
            Options _choice= userChoice.UserInput();
           

            
            switch (_choice)
            {

                case Options.BASIC:
                 Console.WriteLine("Basic Level");
                    break;
                case Options.INTERMEDIATE:
                    Console.WriteLine("Intermediate Level");
                    break;
                case Options.ADVANCED:
                    Console.WriteLine("Advanced Level");
                    break;
                default:
                    Console.WriteLine("invalid input");
                    userChoice.UserInput();
                    break;

            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    class CheckConditionType
    {
        
        LevelDeclaringType levelChoice = new LevelDeclaringType();

        public void CheckCondition(Options _choice)
        {
            switch (_choice)
            {
                case Options.BASIC:
                    Console.WriteLine("Basic Level");
                    string basicLevelPath = @"C:\Users\hemanth.p\Documents\GitHub\latebinding-using-reflection-hemanth111p\GameApp\bin\Debug\LevelLibs\BasicLevelLib.dll";
                    string basicLevelType = "BasicLevelLib.BasicLevelType";
                    string basicLevelMethod = "Play";     
                    levelChoice.Level(basicLevelPath, basicLevelType, basicLevelMethod);
                    
                    break;

                case Options.INTERMEDIATE:
                    Console.WriteLine("Intermediate Level");
                    string intermediateLevelPath = @"C:\Users\hemanth.p\Documents\GitHub\latebinding-using-reflection-hemanth111p\GameApp\bin\Debug\LevelLibs\IntermediateLevelLib.dll";
                    string intermediateLevelType = "IntermediateLevelLib.IntermediateLevelType";
                    string intermediateLevelMethod = "Start";
                    levelChoice.Level(intermediateLevelPath, intermediateLevelType, intermediateLevelMethod);                    
                                   break;

                case Options.ADVANCED:
                    Console.WriteLine("Advanced Level");
                    string advancedLevelPath = @"C:\Users\hemanth.p\Documents\GitHub\latebinding-using-reflection-hemanth111p\GameApp\bin\Debug\LevelLibs\AdvancedLevelLib.dll";
                    string advancedLevelType = "AdvancedLevelLib.AdvancedLevelType";
                    string advancedLevelMethod = "Begin";
                    levelChoice.Level(advancedLevelPath, advancedLevelType, advancedLevelMethod); ;
                    break;
                    

            }
            

        }

        
    }
    
}

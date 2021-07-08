using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    class CheckConditionType
    {
        BasicLevelReflection _basicLevel = new BasicLevelReflection();
        IntermediateLevelReflection _intermediateLevel = new IntermediateLevelReflection();
        AdvancedLevelReflection _advancedLevel = new AdvancedLevelReflection();

        public void CheckCondition(Options _choice)
        {
            switch (_choice)
            {
                case Options.BASIC:
                                    // basicLevel.BasicLevel();
                    string path = @"C:\Users\hemanth.p\Documents\GitHub\latebinding-using-reflection-hemanth111p\GameApp\bin\Debug\LevelLibs\BasicLevelLib.dll";
                    string type = "BasicLevelLib.BasicLevelType";
                    string method = "Play";                   
                    _basicLevel.BasicLevel(path, type, method);
                    break;

                case Options.INTERMEDIATE:
                                   _intermediateLevel.IntermediateLevel();                    
                                   break;

                case Options.ADVANCED:
                                    _advancedLevel.AdvancedLevel();                   
                                       break;
                    

            }
            

        }

        
    }
    
}

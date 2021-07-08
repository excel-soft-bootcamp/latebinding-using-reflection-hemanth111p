using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    class IntermediateLevelReflection
    {
        public void IntermediateLevel()
        {
            Console.WriteLine("Intermediate Level");
            System.Reflection.Assembly intermediateLevelLib =
                    System.Reflection.Assembly.LoadFile(@"C:\Users\hemanth.p\Documents\GitHub\latebinding-using-reflection-hemanth111p\GameApp\bin\Debug\LevelLibs\IntermediateLevelLib.dll");
            System.Type intermediateTypeClassRef = intermediateLevelLib.GetType("IntermediateLevelLib.IntermediateLevelType");

            if (intermediateTypeClassRef != null)
            {
                if (intermediateTypeClassRef.IsClass)
                {

                    Object objRef = System.Activator.CreateInstance(intermediateTypeClassRef);
                    System.Reflection.MethodInfo _methodRef = intermediateTypeClassRef.GetMethod("Start");
                    if (!_methodRef.IsStatic)
                    {
                        object result = _methodRef.Invoke(objRef, new object[] { "hemanth" });
                        Console.WriteLine(result.ToString());
                    }

                }

            }
        }
    }
}

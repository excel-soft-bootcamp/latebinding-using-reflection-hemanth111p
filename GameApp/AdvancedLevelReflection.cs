using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    class AdvancedLevelReflection
    {
        public void AdvancedLevel()
        {
            Console.WriteLine("Advanced Level");
            System.Reflection.Assembly advancedLevelLib =
            System.Reflection.Assembly.LoadFile(@"C:\Users\hemanth.p\Documents\GitHub\latebinding-using-reflection-hemanth111p\GameApp\bin\Debug\LevelLibs\AdvancedLevelLib.dll");
            System.Type advancedTypeClassRef = advancedLevelLib.GetType("AdvancedLevelLib.AdvancedLevelType");

            if (advancedTypeClassRef != null)
            {
                if (advancedTypeClassRef.IsClass)
                {

                    Object objRef = System.Activator.CreateInstance(advancedTypeClassRef);
                    System.Reflection.MethodInfo _methodRef = advancedTypeClassRef.GetMethod("Begin");
                    if (!_methodRef.IsStatic)
                    {

                        object result = _methodRef.Invoke(objRef, new object[] { "hemanth", 5 });
                        Console.WriteLine(result.ToString());
                    }

                }

            }
        }
    }
}

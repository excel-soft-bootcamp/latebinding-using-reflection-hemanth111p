using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    class LevelDeclaringType
    {
        public void Level(string path, string classType, string method)
        {
            
            System.Reflection.Assembly levelLib =
      System.Reflection.Assembly.LoadFile(path);
            System.Type allLevelTypeClassRef = FindClass(levelLib, classType);
            Object objRef = System.Activator.CreateInstance(allLevelTypeClassRef);
            System.Reflection.MethodInfo _methodRef = allLevelTypeClassRef.GetMethod(method);
            try
            {
                object result = InvokeMethod(objRef, _methodRef, new object[] { });
                Console.WriteLine(result.ToString());
            }

            catch
            {
                try
                {
                    object result = InvokeMethod(objRef, _methodRef, new object[] {"hemanth" });
                    Console.WriteLine(result.ToString());
                }
                catch
                {
                    object result = InvokeMethod(objRef, _methodRef, new object[] {"hemanth",10 });
                    Console.WriteLine(result.ToString());
                }
            }


        }
        System.Type FindClass(System.Reflection.Assembly _assemblyRef, String name)
        {
            System.Type classType = _assemblyRef.GetType(name);
            if (classType != null)
            {
                if (classType.IsClass)
                {
                    return classType;
                }
            }
            return null;
        }
        object InvokeMethod(object source, System.Reflection.MethodInfo methodRef, object[] arguments)
        {
            return methodRef.Invoke(source, arguments);

        }

    }


}
   

        

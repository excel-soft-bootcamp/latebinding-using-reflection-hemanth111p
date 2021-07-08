using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    class BasicLevelReflection
    {
        public void BasicLevel(string path,string classType,string method)
        {
            Console.WriteLine("Basic Level");
            System.Reflection.Assembly basicLevelLib =
      System.Reflection.Assembly.LoadFile(path);

                    System.Type basicLevelTypeClassRef = basicLevelLib.GetType(classType);
                    if (basicLevelTypeClassRef != null)
                    {
                        if (basicLevelTypeClassRef.IsClass)
                        {

                            Object objRef = System.Activator.CreateInstance(basicLevelTypeClassRef);

        System.Reflection.MethodInfo _methodRef = basicLevelTypeClassRef.GetMethod(method);
                            if (!_methodRef.IsStatic)
                            {

                                object result = _methodRef.Invoke(objRef, new object[] { });
        Console.WriteLine(result.ToString());
                            }

}

                    }
        }
    }
}

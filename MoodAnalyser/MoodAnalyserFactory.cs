using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        public string ClassName;
        public string Constructor;
        public MoodAnalyserFactory(string className, string constructor)
        {
            this.ClassName = className;
            this.Constructor = constructor;
        }


        public static object FactoryMethod(MoodAnalyserFactory factory, string message)
        {
            if ("HappySad" == factory.Constructor)
            {
                try
                {
                    /*Assembly executing = Assembly.GetExecutingAssembly();
                    Type AnaylseType = executing.GetType(factory.ClassName);
                    var MyObj= Activator.CreateInstance(AnaylseType);
                    return MyObj;*/

                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type AnaylseType = executing.GetType(factory.ClassName);
                    ConstructorInfo ctor = AnaylseType.GetConstructor(new[] { typeof(string) });
                    object MyObj = ctor.Invoke(new object[] { message });
                    return MyObj;
                }
                catch
                {
                    throw new CustomException(CustomException.ExceptionType.CLASS_NOT_FOUND, "class name is wrong");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "constructor name is wrong");
            }
        }
    }
}

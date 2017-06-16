using System;
using System.IO;
using System.Reflection;

namespace CSTheSixthLab
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            Console.WriteLine("Hello World!");
            //    Assembly assembly = Assembly.Load(new System.Reflection.AssemblyName("C:\\Users\\Vitalik\\Documents\\Visual Studio 2017\\Projects\\CSTheSixthLab\\CSTheSixthLab\\bin\\Debug\\netcoreapp1.1\\CSTheSixthLab.dll"));
            Assembly assembly = Assembly.Load(new AssemblyName("CSTheSixthLab"));  
            Type type = assembly.GetType("CSTheSixthLab.Phone");

            if (type != null)
            {
                MethodInfo[] methodsInfo = type.GetMethods();

                foreach (MethodInfo methodInfo in methodsInfo)
                {
                    ParameterInfo[] parameters = methodInfo.GetParameters();

                    foreach (ParameterInfo parameter in parameters)
                    {
                        if (parameter.ParameterType != typeof(String)) flag = false;
                    }

                    if (flag)
                    {
                        String[] values = new String[parameters.Length];
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            Console.WriteLine("Enter the " + parameters[i].Name);
                            values[i] = Console.ReadLine();
                        }
                        object classInstance = Activator.CreateInstance(type, null);
                        Object result = methodInfo.Invoke(classInstance, values);
                        if (methodInfo.ReturnType != typeof(void)) Console.WriteLine(result);
                        Console.ReadKey();
                    }
                    flag = true;
                }
            }                 
        }
    }
}
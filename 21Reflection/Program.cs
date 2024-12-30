using System.Reflection;

namespace _21Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string assemblypath = @"C:\240845920024\DotNet\20CMathLib\bin\Debug\net6.0\20CMathLib.dll";
            Assembly asm = Assembly.LoadFrom(assemblypath);

            Type[]  types = asm.GetTypes();

            string firstType = types[0].Name;
            Console.WriteLine($"Name of Class is {firstType}");
            string fullName = types[0].FullName;
            Console.WriteLine($"Full Name of Class is {fullName}");

            for (int i = 0; i < types.Length; i++)
            {
                Type type = types[i]; //CMath
                object dynamicallyCreatedObj = asm.CreateInstance(type.FullName);

                MethodInfo[] allMethods= type.GetMethods();
                string methodSignature = null;

                for (int j = 0; j < allMethods.Length; j++) { 
                MethodInfo method = allMethods[j];
                    //int Add (
                    methodSignature = method.ReturnType + " " + method.Name + "(";
                    ParameterInfo[] allParameters = method.GetParameters();

                    object[] inputParameters = new object[allParameters.Length] ;

                    for (int k = 0; k < allParameters.Length; k++)
                    {
                        ParameterInfo param = allParameters[k];

                        //int Add(int x , int y

                        methodSignature = methodSignature +  param.ParameterType.ToString() + " " + param.Name + ",";


                    }

                    methodSignature = methodSignature.TrimEnd(',') + " )";
                    Console.WriteLine(methodSignature);

                }

            }
        }
    }
}

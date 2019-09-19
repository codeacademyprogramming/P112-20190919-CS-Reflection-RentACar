using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Esger";
            //Type t = name.GetType();
            //Console.WriteLine(t.Name);
            //Console.WriteLine(t.FullName);


            //string[] names = { "Anar" };
            //Type t2 = names.GetType();

            //Console.WriteLine(t2.Name);
            //Console.WriteLine(t2.FullName);
            //Console.WriteLine(t2.IsArray);

            //Console.WriteLine("---------------");
            //Console.WriteLine(typeof(System.Int32).Assembly);



            Assembly assembly = Assembly.LoadFile(@"C:\Users\sattar\Desktop\Test.dll");
            Type type = assembly.GetType("Test.Calculator");
            object myInstance =  Activator.CreateInstance(type);

            MethodInfo method = type.GetMethod("Add");
            object[] parameters = new object[] { 5, 10};
           object result =  method.Invoke(myInstance, parameters);

            Console.ReadLine();
        }
    }
}

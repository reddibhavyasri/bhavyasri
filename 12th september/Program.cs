using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace sep12thasnmnt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\User\\source\\repos\\calculator\\bin\\Debug\\calculator.dll";
            Assembly asm = Assembly.LoadFrom(path);
            Type[] types = asm.GetTypes();
            Type t = null;
            foreach (var item in types)
            {
                t = asm.GetType(item.FullName);
                object obj = Activator.CreateInstance(t);
                item.InvokeMember("Cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[] { 12 });
                item.InvokeMember("sqrt",BindingFlags.Public|BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[] { 14 });    
                break;


            }
            Console.ReadLine();

        }
    }
}
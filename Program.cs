using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflect
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        static void ListPropers(Type t)
        {
            Console.WriteLine("*************Properties***************8");
            var list = from l in t.GetProperties() select l.Name;
            foreach (var name in list)
                Console.WriteLine("----> {0}", name);
            Console.WriteLine();

        }

        static void ListMethods(Type t)
        {
            Console.WriteLine("*************Methods***************8");
            var list = from l in t.GetMethods() select l.Name;
            foreach (var name in list)
                Console.WriteLine("----> {0}", name);
            Console.WriteLine();

        }

        static void ListFields(Type t)
        {
            Console.WriteLine("*************FIELDS***************8");
            var list = from l in t.GetFields() select l.Name;
            foreach(var name in list)            
                Console.WriteLine("----> {0}", name);
            Console.WriteLine();

        }

        static void ListInterfaces(Type t)
        {
            Console.WriteLine("*************Interfaces***************8");
            var list = from l in t.GetInterfaces() select l.Name;
            foreach (var name in list)
                Console.WriteLine("----> {0}", name);
            Console.WriteLine();

        }

        static void ListVariousStats(Type t)
        {

            Console.WriteLine("*********************");
            Console.WriteLine("Base class is: {0}", t.BaseType);
            Console.WriteLine("Is type abstract? {0}", t.IsAbstract);
            Console.WriteLine("Is type sealed? {0}", t.IsSealed);
            Console.WriteLine("Is type generic? {0}", t.IsGenericTypeDefinition);
            

            Console.WriteLine("Is type a class type? {0}", t.IsClass);
            Console.WriteLine();
        }
    }
}

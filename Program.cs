using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Task_7_1
{
    class Test
    {
        private string Nname;
        public String Name {
            get { return Nname;}
            set { Nname = value; }
        }

        public override string ToString()
        {
            return Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object>() { 1,new Test() { Name = "456" } , 3, 4, new Test() { Name = "456" } };
            object[] array = new object[] { 1, list, new Test() { Name = "789" } };
            //object obj = array;

            foreach (var VAR in Reflection.ConstructEnumerator(array))
            {
                Console.WriteLine(VAR);
            }
            Console.WriteLine();
            foreach (var VAR in Reflection.ConstructEnumerator1(array))
            {
                Console.WriteLine(VAR);
            }
            Console.Read();
        }
    }
}

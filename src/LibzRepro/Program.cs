using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibzRepro
{
    class Program
    {
        public static int Foo()
        {
            var client = new RestSharp.RestClient();
            return client.Encoding.ToString().Length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Foo());
            var instance = new Lib.Class1();
            Console.WriteLine(instance.Foo());

            Console.WriteLine("I worked!");
        }
    }
}

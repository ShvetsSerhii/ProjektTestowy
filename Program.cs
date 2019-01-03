using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_3_1_19
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteHello();

            Console.WriteLine("1+1="+
                Calculator.add(1, 1)
                );


            Console.ReadLine();
            
        }
        
        public static void WriteHello()
        {
            Console.WriteLine("Hello world");
        }
    }
}

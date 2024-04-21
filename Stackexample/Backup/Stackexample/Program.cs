using System;
using System.Collections;
using System.Text;

namespace Stackexample
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack stackObject = new Stack();
            stackObject.Push("Joydip");
            stackObject.Push("Steve");
            stackObject.Push("Jini");
            while (stackObject.Count > 0)
                Console.WriteLine(stackObject.Pop());
            Console.ReadLine();
            Console.ReadKey();

        }
    }
}

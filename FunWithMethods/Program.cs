using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Methods\n");
            int x = 9, y = 10;
            Add(x, y, out int ans);
            Console.WriteLine($"Before call: x: {x}, y: {y}");
            Console.WriteLine($"Answer is: {ans}");
            Console.WriteLine($"After call: x: {x}, y: {y}");
            Console.WriteLine();

            //string dateString="111";
            //DateTime.TryParse(dateString, out _);

            string[] stringArray = { "one", "two", "three" };
            int pos = 1;
            Console.WriteLine($"Before: {stringArray[0]}, {stringArray[1]}, {stringArray[2]}");
            ref var refOutput = ref SampleRefReturn(stringArray, pos);
            refOutput = "new";
            Console.WriteLine($"After: {stringArray[0]}, {stringArray[1]}, {stringArray[2]}");

            //params
            //optional argument
            //named arguments
            //overloaded methods
            //Local functions
            Console.ReadLine();
        }

        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
            //x = 10000;
            //y = 88888;
            //Console.WriteLine($"During call: x: {x}, y: {y}");
        }

        public static ref string SampleRefReturn(string[] strArray, int position)
        {
            return ref strArray[position];
        }
    }
}

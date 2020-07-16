// Data Types, Boxing and Unboxing, String and StringBuilder and it's performance
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TrainingDay02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Types in C#

            int num = 1000;
            Console.Write(num);
            Console.Write('\n');

            char charValue = 'A';
            Console.Write(charValue);
            Console.Write('\n');

            String strValue = "Shani Kumar Gupta";
            Console.Write(strValue);
            Console.Write('\n');

            long longValue = 2222233242442323399;
            Console.Write(longValue);
            Console.Write('\n');

            float floatValue = 233.55555555F;
            Console.WriteLine(floatValue);
            Console.Write('\n');

            decimal decimalValue = 2.999M;
            Console.WriteLine(decimalValue);

            int size = sizeof(int);
            Console.WriteLine("Size of integer :" + size);

            int minValue = int.MinValue;
            int maxValue = int.MaxValue;
            Console.WriteLine("Min value is :" + minValue + " and Max value is :" + maxValue);

            // Boxing and Unboxing
            int number = 1000;
            Object obj = number; // Boxing

            int latestValue = (int)obj; // Unboxing

            Console.WriteLine("Boxing : "+obj);
            Console.WriteLine("Unboxing : " + latestValue);


            // String and String Builder

            // String
            String test = "Hello";
            test = test + "Country";
            test = test + "India";

            Console.WriteLine("String : " + test);

            // String Builder
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append("Country");
            sb.Append("India");

            Console.WriteLine(sb);

            String s = "";
            for(int i = 0; i <= 10; i++)
            {
                s = s + i;
            }
            Console.WriteLine("String Value : " + s);

            StringBuilder stb = new StringBuilder();
            for(int i = 0; i <= 10; i++)
            {
                stb.Append(i);
            }
            Console.WriteLine("StringBuilder Value : " + stb.ToString());

            // Check Performance of String and StringBuilder

            Stopwatch sw1 = new Stopwatch();
            String s1 = "";

            sw1.Start();
            for (int i = 0; i <= 10; i++)
            {
                s1 = s1 + i;
            }
            sw1.Stop();


            Stopwatch sw2 = new Stopwatch();
            StringBuilder sb1 = new StringBuilder();

            sw2.Start();
            for (int i = 0; i <= 10; i++)
            {
                sb1.Append(i);
            }
            sw2.Stop();

            Console.WriteLine("Time Taken by String : " + sw1.ElapsedMilliseconds);
            Console.WriteLine("Time Taken by StringBuilder : " + sw2.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}

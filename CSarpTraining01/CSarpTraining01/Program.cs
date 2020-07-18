// DataType, Boxing and Unboxing, String and StringBuilder
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSarpTraining01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic Hello World Program
            Console.WriteLine("Hello C# !!");
            Console.Write("I am Shani Kumar Gupta");
            Console.WriteLine();
            Console.WriteLine("<---------------------------------------------------------------------------------------------->");

            // DataTypes in C#

            // int datatype
            int num = 10234;
            int size = sizeof(int);
            int maxSize = int.MaxValue;
            int minSize = int.MinValue;
            Console.WriteLine("Integer Number : " + num);
            Console.WriteLine("int size : " + size);
            Console.WriteLine("int minValue : " + minSize + " and int maxValue : " + maxSize);

            // if you assign a new value to an existing variable, it will overwrite the previous value
            int myValue = 15;
            myValue = 20; // now the value of myValue is 20
            Console.WriteLine("myValue is : " + myValue);

            // const keyword
            const double PI = 3.14;
            // PI = 23.45; error occurs
            Console.WriteLine("PI : " + PI);

            // Single line comment
            /* Muilty line
             * comment */

            // float datatype
            float num1 = 10.345634555555555552322F;
            int floatSize = sizeof(float);
            Console.WriteLine("Float number : " + num1);
            Console.WriteLine("Float size : " + floatSize);
            Console.WriteLine("float minValue : " + float.MinValue + " and float maxValue : " + float.MaxValue);

            //double
            double num2 = 1013271571.34563455555555555232231111111;
            int doubleSize = sizeof(double);
            Console.WriteLine("Float number : " + num2);
            Console.WriteLine("Float size : " + doubleSize);
            Console.WriteLine("double minValue : " + double.MinValue + " and double maxValue : " + double.MaxValue);

            // char
            char ch1 = 'A';
            int charSize = sizeof(char);
            Console.WriteLine("Char value : " + ch1);
            Console.WriteLine("Char Size : " + charSize);
            Console.WriteLine("Char minValue : " + char.MinValue + " Char maxValue : " + char.MaxValue);

            // string
            string str = "Shani";
            Console.WriteLine("String value : " + str);

            // long
            long longValue = 2324598327897257939L;
            Console.WriteLine("Long Value : " + longValue);

            // decimal
            decimal decimalValue = 23.456M;
            Console.WriteLine("Decimal Value : " + decimalValue);

            // bool
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

            // Boxing and Unboxing
            int value = 2345;
            Object obj = value; // Boxing

            int val = (int) obj; // Unboxing

            // String and StringBuilder
            // 1. String

            String str1 = "Shani";
            str1 = str1 + " Kumar";
            str1 = str1 + " Gupta";
            Console.WriteLine("String value : " + str1);

            // 2. StringBuilder

            StringBuilder sb = new StringBuilder();
            sb.Append("Gupta");
            sb.Append(" Kumar");
            sb.Append(" Shani");

            Console.WriteLine("StringBuilder value : " + sb);

            // Check performance of String and StringBuilder

            Stopwatch sw1 = new Stopwatch();
            String s1 = "";

            sw1.Start();
            for(int i = 1; i <= 1000; i++)
            {
                s1 = s1 + i;
            }
            sw1.Stop();

            Console.WriteLine("Time taken by String : " + sw1.ElapsedMilliseconds);

            Stopwatch sw2 = new Stopwatch();
            StringBuilder sb1 = new StringBuilder();

            sw2.Start();
            for(int i = 1; i <= 1000; i++)
            {
                sb1.Append(i);
            }
            sw2.Stop();

            Console.WriteLine("Time taken by StringBuilder : " + sw2.ElapsedMilliseconds);

            Console.WriteLine("<------------------------------------------------------------------------------------------------------>");

            // Type Casting
            // 1. Implicit Type Casting (automatically)
            int num3 = 234;
            double intImplicitTypeCasting = num3;
            Console.WriteLine("Implicit Type Casting from int to double : " + num3);

            // 2. Explicit Type Casting
            double doubleValue1 = 23.456D;
            int myInt = (int)doubleValue1;
            Console.WriteLine("Explicit Type Casting from double to int : " + myInt);

            Console.WriteLine("<------------------------------------------------------------------------------------------------------>");

            Console.WriteLine("Take user input through console");
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("My Name : " + name);

            Console.Write("Enter integer number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numeric value : "+ number);
            Console.ReadLine();
        }
    }
}

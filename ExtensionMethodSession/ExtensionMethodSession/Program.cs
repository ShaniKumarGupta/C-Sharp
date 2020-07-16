using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodSession // class and method both will be static
{
    class Program 
    {
        static void Main(string[] args)
        {
            int a = 11; // Console.Read();
            bool result = a.IsEven();
            Console.WriteLine("Result : " + result);

            int b = 12;
            bool result1 = ExtensionMethod.IsEven1(b);
            Console.WriteLine("Result1 : " + result1);

            string inputa = "Hello";
            string inputb = "world";
            string resultString = "";
            Console.WriteLine(resultString.concatenate(inputa, inputb));

            SealedDemo obj = new SealedDemo();
            obj.MethodB();
            var res = obj.MethodC();
            Console.WriteLine(res);


            Console.ReadLine();
        }
    }
}

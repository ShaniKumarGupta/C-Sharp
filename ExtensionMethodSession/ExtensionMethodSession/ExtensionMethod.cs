using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodSession
{
    public static class ExtensionMethod
    {
        public static bool IsEven(this int i) //binding parameter this int i
        {
            return (i % 2 == 0);
        }

        public static bool IsEven1(int i) //binding parameter this int i
        {
            return (i % 2 == 0);
        }

        public static string concatenate(this string i, string a, string b)
        {
            return a + "," + b;
        }

        public static string MethodC(this SealedDemo obj)
        {
            return "Sealed class extension method";
        }
    }
}

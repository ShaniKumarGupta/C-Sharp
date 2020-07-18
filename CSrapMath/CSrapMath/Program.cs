using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSrapMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // Math class method
            int x = 12;
            int y = 20;
            double z = -45.78D;
            double s = 34.56;
            Console.WriteLine("Max Value : "+ Math.Max(x, y));
            Console.WriteLine("Min Value : " + Math.Min(x, y));
            Console.WriteLine("Sqrt Value : " + Math.Sqrt(x));
            Console.WriteLine("Absolute Value : " + Math.Abs(z));
            Console.WriteLine("Round Value : " + Math.Round(s));

            // String class method
            string name = "Shani Kumar Gupta";
            Console.WriteLine("Name length : " + name.Length);
            Console.WriteLine("Name in uppercase : " + name.ToUpper());
            Console.WriteLine("Name in lowercase : " + name.ToLower());
            Console.WriteLine("Name without whitespace : " + name.Trim());

            // string concate
            string firstName = "Shani";
            string lastName = " Gupta";
            string fullName = string.Concat(firstName,lastName);
            Console.WriteLine("Full Name after concate : " + fullName);

            // String Interpolation
            Console.WriteLine("String Interpolation: ");
            string fName = "Aman";
            string lName = " Kumar";
            string name1 = $"My full name is : {fName} {lName}";
            Console.WriteLine(name1);

            // Access string
            string greeting = "Hello";
            Console.WriteLine(greeting[0]);
            Console.WriteLine("Indexof e : " + greeting.IndexOf('e'));
            Console.ReadLine();
        }
    }
}

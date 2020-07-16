// Operators, Statement, Arrays and Strings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDay03
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Operators and It's types
            // --> Arithmetic Operators

            int a = 10, b = 5, c = 5;

            c = a + b; // Addition Operator where a and b is operands
            c = a - b; // Subtract Operator
            c = a * b; // Multiply Operator
            c = a / b; // Divide Operator
            c = a % b; // Modulus(Remainder) Operator

            // Unary Operator (Airthmetic Operator)
            // Increment and Decrement Operator

            c = a++; // Postfix increment
            c = a--; // Postfix decrement

            c = ++a; // Prefix increment
            c = --a; // Prefix decrement

            // Assignment Operator

            c = b;
            c += b; // c = c + b;
            c -= b; // c = c - b;
            c *= b; // c = c * b;

            // Relational Operators (Comparing the values)
            bool result;
            result = c == b; // Either true or false // Equal to Operator

            result = a != b; // Not Equal to operator

            result = a > b; // Greater than operator

            result = a >= b; // Greater than or Equal to operator

            result = a < b; // Less than operator

            result = a <= b; // Less than or Equal to operator

            // Logical Operators

            result = a == b && b == c; // And logical operator

            result = a == b || b == c; // OR operator

            result = !(1 == 1); // Not operator

            // Statements

            // 1. If statement
            // 2. else statement
            // 3. else if statement
            // 4. Else if lader


            if (a == b)
            {
                Console.WriteLine("This is my if condition");
            }
            else if(b == c)
            {
                Console.WriteLine("This is my else if condition");
            }
            else if (1 == 1)
            {
                Console.WriteLine("This is my else if condition");
            }
            else
            {
                Console.WriteLine("Thisis my else part");
            }

            // 5. Nested if statement

            if (a == b)
            {
                Console.WriteLine("This is my if condition");
                if (a == b)
                {
                    Console.WriteLine("This is my if condition");
                    if (1 == 2)
                    {
                        Console.WriteLine("This is my if condition");
                    }
                    else
                    {
                        Console.WriteLine("else part");
                    }
                }

            }

            // Switch statement

            int number = 5;
            switch (number)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    break;
            }


            // Control Statement
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            int[] array = new int[4] { 1, 2, 3, 4 };
            foreach(int value in array)
            {
                Console.WriteLine(value);
            }

            int count = 0;
            while(count < 3)
            {
                Console.WriteLine(count);
                count++;
            }

            do
            {
                Console.WriteLine();
            }
            while (count < 3);
            {
                count++;
            };


            // continue statements
            for(int i = 0; i <= 5; i++)
            {
                if(i == 2)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // Break statement
            for (int i = 0; i <= 5; i++)
            {
                if (i == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // Jump statement
            JumpToStatement:
            for (int i = 0; i <= 5; i++)
            {
                if (i == 2)
                {
                    goto JumpToStatement;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // Arrays and String

            string name01 = "Ronit";
            string name02 = "Sahil";
            string name03 = "Chetan";

            string[] names = new string[] { "Shani", "Aman", "Vivek" };

            names[2] = "Matt";

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            // Array sort method
            Array.Sort(names);


        }
    }
}

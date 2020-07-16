//Constant and Enum
//List and IEnumerable
//Email from Template
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSession04
{
    class Program
    {
        enum Weeks : int // int type of enum
        {
            Sunday, // default value is 0 or we can use Sunday = 1 
            Monday,
            Tuesday,
            Wednesday,
            Thrusday,
            Friday,
            Saturday
        }

        public class Employee
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public long Salary { get; set; }
        }

        public class User
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public long Salary { get; set; }
        }
        static void Main(string[] args)
        {
            // 1. Constant and Enums

            const double PI = 3.14; // Named constant (Remains Same) // We can't re-assign the value

            int radius = 10;

            var area = PI * radius * radius; // used var if we are not able to indentify the type
            // var, dynamic and object
            Console.WriteLine(area);

            // Enum is the collection of const
            // How to access the enum value

            int value = (int)Weeks.Monday;
            Console.WriteLine("Value of Sunday is : " + (int)Weeks.Sunday);
            Console.WriteLine("Value of Monday is : " + value); // Formate Ctrl + a and Ctrl + F

            Console.WriteLine("----------------------------------------------------------------------------------------");

            // 2. List and IEnumerable
            Employee emp1 = new Employee { ID = 101, Name = "Ronit", Salary = 5000 };
            Employee emp2 = new Employee { ID = 102, Name = "Shani", Salary = 4000 };
            Employee emp3 = new Employee { ID = 103, Name = "Aman", Salary = 3000 };

            List<Employee> employees = new List<Employee>();
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            employees[1] = emp3;

            employees.Insert(0, emp3);

            List<Employee> eList = employees.Where(x => x.Salary > 5000).ToList();
            //It will gives records with salary greater than 5000


            List<Employee> eList1 = employees.OrderBy(x => x.Name).ToList();
            foreach (Employee emp in employees)
            {
                Console.WriteLine("ID is {0}, Name is {1}, Salary is {2}", emp.ID,emp.Name,emp.Salary);
            }

            Employee empSingle = employees.Where(x => x.Name == "Ronit").FirstOrDefault();
            Console.WriteLine("ID is {0}, Name is {1}, Salary is {2}", empSingle.ID, empSingle.Name, empSingle.Salary);

            List<string> list = new List<string>(); // List of string type
            list.Add("Shani");

            // List is inherited by IEnumerable to make some alteration


            // 3. Email Templates (HTML)

            StringBuilder sb = new StringBuilder();
            sb.Append("Welcome User");

            // read html file

            string name = "[[]]";
            name = name.Replace("[[]]", "Ronit");


            Console.ReadLine();
        }
    }
}

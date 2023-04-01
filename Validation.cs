using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ishan_test
{
    public class Validation
    {
        public int checkid()
        {
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("enter the valid input pls");
            }
            return id;
        }
        public int index()
        {
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("enter the valid input pls");
            }
            return id;
        }

        public int checkid_delete()
        {
            int inx;
            while (!int.TryParse(Console.ReadLine(), out inx))
            {
                Console.WriteLine("enter the valid input pls");
            }
            return inx;
        }

        public string checkname(string name)
        {
            while (!Regex.Match(name, "^[A-Za-z\\s]+$").Success)
            {
                Console.WriteLine("Invalid name");
                name = Console.ReadLine();

            }
            return name;
        }

        public int CheckSalary(string salry)
        {
            int salary;
            while (!int.TryParse(salry, out salary))
            {
                Console.WriteLine(" invalid Salary");
                salry = Console.ReadLine();
            }
            return salary;
        }


        public string Checkage(string agee)
        {

            DateTime age;
            while (!DateTime.TryParse(agee, out age))
            {
                Console.WriteLine(" invalid age");
                agee = Console.ReadLine();
            }

            int agv = DateTime.Now.Subtract(age).Days;
            agv = agv / 365;
            return agv.ToString();


        }

        public int checkdepartmentId(string dept_id)
        {
            int ID;
            while (!int.TryParse(dept_id, out ID))
            {
                Console.WriteLine(" invalid department id");
                dept_id = Console.ReadLine();
            }
            return ID;
        }

        public string checktechnology(string technology)
        {
            while (!Regex.Match(technology, "^[A-Za-z\\s]+$").Success)
            {
                Console.WriteLine("Invalid name");
                technology = Console.ReadLine();

            }
            return technology;
        }










    }

}




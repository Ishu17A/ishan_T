using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ishan_test
{
    public class Add
    {
        Validation valadd = new Validation();
        public void add_details(List<Employee> list)
        {
            Console.WriteLine("add operation");
            Console.WriteLine("enter the Name :");
            var name = valadd.checkname(Console.ReadLine());
            Console.WriteLine("enter the Age  (format : yyyy-mm-dd) :");
            var age = valadd.Checkage(Console.ReadLine());
            Console.WriteLine("enter the department ID :");
            var department = valadd.checkdepartmentId(Console.ReadLine());
            Console.WriteLine("enter the technology :");
            var technology = technologies();
            Console.WriteLine("enter the salary :");
            var salary = valadd.CheckSalary(Console.ReadLine());
            int userid = 0;
            if (list.Count == 0)
            {
                userid = 1;
            }
            else
            {
                userid = list.Max(emp => emp.Id);
                userid++;
            }








            Employee add_to = new Employee(userid, name, age, department.ToString(), technology, salary.ToString());

            list.Add(add_to);
        }


        public string technologies()
        {
            int no_of_technologies;
            while (!int.TryParse(Console.ReadLine(), out no_of_technologies))
            {
                Console.WriteLine();
                Console.WriteLine(" invalid no of technology");
            }
            string Usertechnology;
            string[] techno_details = new string[no_of_technologies];
            string technology;

            for (int i = 0; i < no_of_technologies; i++)
            {

                Console.WriteLine($"Please Provide Your technology{i + 1}");
                technology = valadd.checktechnology(Console.ReadLine());
                techno_details[i] = technology;
            }
            Usertechnology = string.Join(",", techno_details);
            return Usertechnology;

        }

    }

}

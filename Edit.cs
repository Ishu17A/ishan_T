using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ishan_test
{
    public class Edit
    {


        Validation vala = new Validation();
        public void update_details(List<Employee> list)
        {
            Console.WriteLine("update operation");
            Console.WriteLine("enter the index you have to update ");
            var updateId = vala.index();
            var updateObj = list.FirstOrDefault(x => x.Id == updateId);

            if (updateObj == null)
            {

                Console.WriteLine(" Id not valud  in Employee details sorry");

            }
            else
            {
                Console.WriteLine("UserId Found");
                Console.WriteLine("Please Input the new values");
                Console.WriteLine("Enter Name");
                string nameInput = vala.checkname(Console.ReadLine());
                updateObj.Name = nameInput;
                Console.WriteLine("enter the Age (format : yyyy-mm-dd) :");
                var age = vala.Checkage(Console.ReadLine());
                updateObj.Age = age.ToString();
                Console.WriteLine("enter the department ID :");
                var department = vala.checkdepartmentId(Console.ReadLine());
                updateObj.Department_ID = department.ToString();
                Console.WriteLine("enter the technology :");
                Add add = new Add();
                var technology = add.technologies();
                updateObj.Technologies = technology;
                Console.WriteLine("enter the salary :");
                var salary = vala.CheckSalary(Console.ReadLine());
                updateObj.salary = salary.ToString();
                Console.WriteLine("update done ");

            }

        }
    }
}

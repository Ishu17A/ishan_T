using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ishan_test
{
    public class view
    {

        public void show_details(List<Employee> list)
        {
            if (list.Count > 0)
            {

                Console.WriteLine("Show Table");
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5}", "ID", "Name", "AGE", "DEPARTMENT ID", "TECHNOLOGY", "SALARY");
                foreach (var item in list)
                {
                    Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5} ", item.Id, item.Name, item.Age, item.Department_ID, item.Technologies, item.salary);
                }
            }
            else
            {
                Console.WriteLine("list is null");
            }
        }

    }
}

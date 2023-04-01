using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ishan_test
{

    public class Delete
    {
        public void delete_details(List<Employee> list)
        {
            Validation vala = new Validation();
            Console.WriteLine("enter the index you want to remove : ");
            int id = vala.checkid_delete();
            var itemToRemove = list.Find(r => r.Id == id);

            if (itemToRemove == null)
            {

                Console.WriteLine(" Id not valud  in Employee details sorry");

            }
            else
            {
                list.Remove(itemToRemove);
                Console.WriteLine("Delete done");
            }

        }
    }
}

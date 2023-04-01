using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ishan_test
{
    public  class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string  Age { get; set; }
        public string Department_ID { get; set; }
        public string Technologies { get; set; }
        public string salary { get; set; }


        public Employee(  int userid , string name, string age , string department_id, string technologies , string salary ) { 
        
            this.Name = name;
            this.Age = age;
            this.Department_ID = department_id;
            this.Age =age;
            this.Technologies =technologies;
            this.Id = userid;
            this.salary =salary;
        
        }
    }
}

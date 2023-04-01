using ishan_test;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Data.SqlClient;

internal class Program
{
    public static void Main(string[] args)
    {

        Validation validation = new Validation();
        List<Employee> list = new List<Employee>();

        while (true)
        {

            Console.Write("1-view employee" + "\n"
                + "2-Add employee" + "\n"
                + "3-Edit employee" + "\n"
                + "4-Delete employee" + "\n"
                + "5-save Employee to File" + "\n"
                + "6-Quit Application" + "\n");

            int value = validation.checkid();

            switch (value)
            {
                    case 1:
                    Console.WriteLine("view");
                    view view = new view();
                    view.show_details(list);
                    break;
                    case 2:
                    Console.WriteLine( "add");
                    Add add = new Add();
                    add.add_details(list);
                    break; 
                    case 3:
                    Console.WriteLine("edit");
                    Edit edit = new Edit();
                    edit.update_details(list);
                    break; 
                    case 4:
                    Console.WriteLine("delete");
                    Delete delete = new Delete();  
                    delete.delete_details(list);                    
                    break; 
                    case 5:
                    Console.WriteLine("SAVE EMPLOYEE TO FILE");
                    Filesave filesave = new Filesave();
                 /*   filesave.csv();*/
                    break;
                    case 6:
                    Console.WriteLine("QUIT");
                    return;

                    default:
                    Console.WriteLine("enter the valid input");
                    break;
            }
        Console.ReadLine();
         

        }
    }
}
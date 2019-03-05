using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql01
{
    class Program
    {
        //TODO:1 install entityframwork. add new item>data>ado model>new connection>.>select db

        static void Main(string[] args)
        {
            ConnectToDB connection = new ConnectToDB();

//create temp sorage to hold data
            List<person> local =  connection.ImportPeople();
              Console.WriteLine("test");
            


            Console.ReadLine();
        }
    }
}

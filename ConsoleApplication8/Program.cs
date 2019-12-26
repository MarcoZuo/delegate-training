using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        struct teststruct
        {
            public string firstname, lastname;
            public string name() => firstname + " " + lastname;
            
        }
        static void Main(string[] args)
        {
            teststruct mystruct = new teststruct();
            mystruct.firstname = "Marco";
            mystruct.lastname = "Reus";
            Console.WriteLine(mystruct.name());
            Console.ReadKey();
        }
    }
}

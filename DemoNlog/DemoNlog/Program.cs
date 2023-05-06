using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNlog
{
    public class Program
    {
       public static void Main(string[] args)
        {
            AddNumber add = new AddNumber();
           Console.WriteLine (add.Sum(1,0));
            Console.ReadLine();
        }
    }
}

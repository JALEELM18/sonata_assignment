using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Assig7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your current age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age after 10 years:");
            age = age + 10;
            Console.Write("{0} ", age);
        }
    }
}

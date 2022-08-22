using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ass4
    {
    public static void Main()
        {
            int a = 0, myWord = 1;
            string str = "Hello World!";
            while (a <= str.Length -1)
            {
                if (str[a] == ' ' || str[a] == '\n' || str[a] == '\t')
                {
                myWord++;
                }
                a++;
            }
            Console.WriteLine("Number of words in the string = {0}\n", myWord);
        }
    }
}

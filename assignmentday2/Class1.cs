﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2assi
{
    internal class Class1
    {
        
            static void Main1()
            {
                Console.Write("Current age:");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Your age after 10 years:");
                age = age + 10;
                Console.Write("{0} ", age);
            }
        }
    }

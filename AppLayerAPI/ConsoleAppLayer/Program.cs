﻿using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            var input = Console.ReadLine();
            id = Int32.Parse(input);
            Console.WriteLine(PersonService.Get(id));
        }
    }
}

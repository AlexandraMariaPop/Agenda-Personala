﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Personala
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.FirstName = "MARIE";
            p1.LastName = "ANDERSON";
            p1.ID = 1;
            p1.Email = "AAAA@yahoo.com";
            p1.PhoneNumber = 09876543456789;
            p1.Age = 44;
            
            Console.WriteLine(p1);
            Console.ReadKey();
        }
    }
}
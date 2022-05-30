using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;

namespace Jumping__
{
    class Program
    {
        static void Main(string[] args)
        {
            byte procent = 100;
            byte userprocent = 0;
            Console.WriteLine("Starting Beating lvl...");
            bool whil = true;
            Thread.Sleep(1000);
            while (whil)
            {
                userprocent++;
                Thread.Sleep(700);
                Console.WriteLine("Beating: " + userprocent + "%");
                if (userprocent == procent)
                {
                     whil = false;
                     Console.WriteLine("Level Completed!");
                }
            }
        }
    }
}

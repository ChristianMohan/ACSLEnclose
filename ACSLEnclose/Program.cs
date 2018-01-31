using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ACSLEnclose
{
    class Program
    {
        static void Main(string[] args)
        {

            String expr = "";

            String file = File.ReadAllText(@"C:\Users\eahscs\Desktop\Text.txt");
            String[] lines = file.Split('\n');

            String[] exp = lines[0].Split();
            
        }
    }
}


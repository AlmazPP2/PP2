﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists(@"C:\Week2\Task4.txt"))
            {
                using (FileStream fs = new FileStream(@"C:\Week2\Task4.txt", FileMode.CreateNew, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write("Hello World!");
                    }
                }
            }

            if (!Directory.Exists(@"C:\Week2\Shark"))
            {
                Directory.CreateDirectory(@"C:\Week2\Shark");
            }

            string TheFirstFile = Path.Combine(@"C:\Week2", "Task4.txt");
            string TheSecondFile = Path.Combine(@"C:\Week2\Shark", "Task4.txt");

            if (!File.Exists(@"C:\Week2\Shark\Task4.txt"))
            {
                File.Copy(TheFirstFile, TheSecondFile, true);
            }

            if (File.Exists(@"C:\Week2\Task4.txt"))
            {
                File.Delete(@"C:\Week2\Task4.txt");
            }
        }
    }
}

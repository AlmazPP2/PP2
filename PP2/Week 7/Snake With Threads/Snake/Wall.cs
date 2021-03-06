﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall:GameObject
    {
        public Wall() : base() { }

        public string levelName
        {
            get;
            private set;
        }

        FileSystemInfo[] levels = new DirectoryInfo(@"C:\Users\User\Desktop\PP2\PP2\Week 7\Snake With Threads\Snake\Levels").GetFileSystemInfos();

        public Wall(char sign, int levelNumber, ConsoleColor c) : base(sign, c)
        {
            LoadLevel(levelNumber);
        }

        public void LoadLevel(int number)
        {
            levelName = Path.GetFileNameWithoutExtension(levels[number-1].Name);
            using(StreamReader streamReader = new StreamReader(levels[number-1].FullName))
            {
                int r = 0;
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    for(int c=0; c<line.Length; c++)
                    {
                        if (line[c] == '#')
                        {
                            body.Add(new Point(c, r));
                        }
                    }
                    r++;
                }
            }
        }
    }
}

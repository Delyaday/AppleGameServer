using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleGame
{
    class Apple
    {
        public string FullPath { get; private set; }
        public string EmptyPath { get; private set; }
        public int Count { get; set; }

        public Apple()
        {
           FullPath = "C:\\Users\\qukmo\\Desktop\\C++\\apple.png";
           EmptyPath = "C:\\Users\\qukmo\\Desktop\\C++\\empty.png";
           Count = 0;
        }

        public Apple(string FullPath, string EmptyPath, int Count)
        {
            this.FullPath = FullPath;
            this.EmptyPath = EmptyPath;
            this.Count = Count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Guide
{
    public class Game
    {
        public string Name { get; set; }
        public string Anotaion { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

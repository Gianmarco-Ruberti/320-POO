using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_parachute
{
    public class Para
    {
        private string[] withoutParachute =
   {
         @"     ",
         @"     ",
         @"     ",
         @"  o  ",
         @" /░\ ",
         @" / \ ",
     };
        public string name;
        public int X;
        public int Y;
        public Para(string name)
        {
            this.name = name;
        }
        public void draw()
        {
            for (int i = 0; i < withoutParachute.Length; i++)
            {
                Console.SetCursorPosition(X, i);
                Console.Write(withoutParachute[i]);
            }
        }
    }
}

    

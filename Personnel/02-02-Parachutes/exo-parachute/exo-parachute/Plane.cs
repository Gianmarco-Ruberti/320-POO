using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_parachute
{
    class Plane
    {
        public const int WIDTH = 28;
        public const int HEIGHT = 6;
        private string[] view =
               {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };
        private int _x;
        private int _y;
        public List<Para> Bob;
        public Plane()
        {
            _x = 0;
            _y = Config.SCREEN_HEIGHT;
            Bob = new List<Para>();
        }
        public void update()
        {
            if (_x > Config.SCREEN_WIDTH)
            {
                _x = 0;
            }
            else
            {
                _x++;
            }
        }

        public void draw()
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(_x, i);
                Console.Write(view[i]);
            }
        }
        public void board(Para para)
        {
            this.Bob.Add(para);
        }
    }
}

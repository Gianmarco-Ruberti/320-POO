using System;
using System.Numerics;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Modifier le modèle (ce qui *est*)
                Plane.update();

                // Modifier ce que l'on *voit*
                Console.Clear();
                Plane.draw();

                // Temporiser
                Thread.Sleep(100);
            }
        }
    }
    static class Config
    {
        public const int SCREEN_HEIGHT = 40;
        public const int SCREEN_WIDTH = 150;
    }
    public class Plane
    {
        private int _x;
        private int _y;
        public Plane()
        {
            _x = 1;
            _y = 10;
        }
        public void update()
        {
            _x++;
        }
        private string[] draw =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };
    }
}
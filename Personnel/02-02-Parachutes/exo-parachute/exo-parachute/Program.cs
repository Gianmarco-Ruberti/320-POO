using exo_parachute;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.WindowWidth = Config.SCREEN_WIDTH;
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Plane plane = new Plane();
            while (true)
            {
                // Modifier le modèle (ce qui *est*)
                plane.update();

                // Modifier ce que l'on *voit*
                Console.Clear();
                plane.draw();

                // Temporiser
                Thread.Sleep(100);
            }
        }
    }
}
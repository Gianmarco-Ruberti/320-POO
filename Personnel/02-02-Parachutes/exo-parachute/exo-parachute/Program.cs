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
            //détecte les touche
            ConsoleKeyInfo keyPressed;
            //créer avion et Bob
            Plane plane = new Plane();
            for (int i = 0; i > 10; i++)
            {
                plane.board(new Para("Bob " + i.ToString()));
            }
            while (true)
            {
                Console.Clear();
                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;

                    }
                }
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
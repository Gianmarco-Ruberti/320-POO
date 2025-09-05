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
                
            }
        }
    }
    public class Plane
    {
        private int _x;
        private int _y;
        public Plane()
        {
            _x = 1;
            _y = Config.SCREEN_HEIGHT;
        }
        public void update()
        {
            _x++;
        }
       
        public void draw()
        {
            for (int i = 0; i < view.Length; i++)
            {

            }
        }
    }
}
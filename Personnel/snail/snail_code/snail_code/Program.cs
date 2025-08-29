using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vertical = 10;
            /*
            Console.SetCursorPosition(horizontal, vertical);
            Console.WriteLine(body);
            do 
            {
                Console.SetCursorPosition(horizontal, vertical);
                Console.WriteLine("    ");
                Console.SetCursorPosition(horizontal, vertical);
                horizontal++;
                Console.SetCursorPosition(horizontal, vertical);
                Console.WriteLine(body);
                life--;
                Thread.Sleep(100);
            }while(life!=0);
            Console.SetCursorPosition(horizontal, vertical);
            Console.WriteLine("____");
            */
        }
    }
    public class snail
    {
        public int _life;
        public int _vertical;
        public int _horizontal;
        public string _body;
        public snail(int life, int horizontal, string body)
        {
            this._life = life;
            this._horizontal = horizontal;
            this._body = body;
        }
        public snail()
        {
            this._body = "_@_ö";
            this._life = 50;
            this._horizontal=1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drones.Helpers;


namespace Drones
{
    public partial class Store : Building
    {
        public static readonly int FULLCHARGE = 1000;
        private int _x;
        private int _y;
        private Color _color;
        private int _Id;
        private int PowerConsumption;
        public Store(int x, int y, int Id) : base(x, y)
        {
            _x = x;
            _y = y;
            _color = Color.Red;
            _Id = Id;
            PowerConsumption = GlobalHelpers.alea.Next(FULLCHARGE);
        }
        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }

        public void Update(int interval)
        {
            Console.WriteLine($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, X - 100, Y - 20);
        }
        public override string ToString()
        {
            return $"Lundi: 8h-18h\",\"Mardi: 8h-18h\",\"Mercredi: 8h-18h\"";
        }
    }
}

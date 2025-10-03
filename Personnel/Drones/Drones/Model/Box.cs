using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Box
    {
        private int _x;
        private int _y;
        private Color _color;
        public Box(int x, int y)
        {
            _x = x;
            _y = y;
            _color = Color.BlueViolet;
        }
        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }
    }
}

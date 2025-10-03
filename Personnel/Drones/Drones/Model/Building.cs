using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        protected int _x;
        protected int _y;
        protected Color _color;
        public Building(int x, int y)
        {
            _x = x;
            _y = y;
            _color = Color.Red;
        }
        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }
    }
}

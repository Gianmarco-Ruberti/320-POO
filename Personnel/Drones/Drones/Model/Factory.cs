using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Factory
    {
        private int _x;
        private int _y;
        private Color _color;
        private int _Id;
        public Factory(int x, int y, int Id)
        {
            _x = x;
            _y = y;
            _color = Color.Red;
            _Id = Id;
        }
        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }

        public void Update(int interval)
        {

        }
    }
}

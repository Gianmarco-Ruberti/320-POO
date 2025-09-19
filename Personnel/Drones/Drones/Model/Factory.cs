using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        List<Box> box = new List<Box>();
        public void Update(int interval)
        {
            int frameCount = 0;
            frameCount++;
            if (frameCount % 5 == 0) 
            {
                box.Add(new Box(800, 100));
            }
        }
    }
}

using Drones.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Box
    {
        private Pen boxBrush = new Pen(new SolidBrush(Color.Purple), 3);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(boxBrush, X, Y, 10, 10);
        }
    }
}

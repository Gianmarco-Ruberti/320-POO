using Drones.Helpers;
using Drones.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Factory
    {
        private Pen droneBrush = new Pen(new SolidBrush(Color.Purple), 3);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawImage(Resources.factory, X, Y, 100, 100);
        }
    }
}

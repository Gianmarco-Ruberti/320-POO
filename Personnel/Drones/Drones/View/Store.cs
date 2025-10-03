using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Drones
{
    public partial class Store : Building
    {
        private Pen BuildingBrush = new Pen(color: Color.Blue, 3);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(BuildingBrush, X, Y, 100, 100);
        }
    }
}

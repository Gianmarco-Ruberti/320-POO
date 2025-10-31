using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    class TankContainer : Container
    {
        public TankContainer(int Id, float Weight, bool IsRefrigerated, List<string> Merchandise, string Color) : base(Id, Weight, IsRefrigerated, Merchandise, Color)
        { 

        }
    }
}

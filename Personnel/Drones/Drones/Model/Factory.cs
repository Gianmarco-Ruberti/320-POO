using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drones
{
    public partial class Factory : Building
    {
        public static readonly int FULLCHARGE = 1000;
        private int _Id;
        private int PowerConsumption;
        public Factory (int x, int y, int Id) : base(x, y)
        {
            _Id = Id;
            PowerConsumption = GlobalHelpers.alea.Next(FULLCHARGE);
        }
        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }
        List<Box> box = new List<Box>();
        public void Update(int interval)
        {
            PowerConsumption--;
            Console.WriteLine($"{_Id}{this}", TextHelpers.drawFont, TextHelpers.writingBrush, X - 30, Y - 20);
            int frameCount = 0;
            frameCount++;
            if (frameCount % 5 == 0) 
            {
                box.Add(new Box(800, 100));
            }
        }
        public override string ToString()
        {
            return $"PowerConsumption ({((int)((double)PowerConsumption / FULLCHARGE * 100)).ToString()}%)";
        }
    }
}

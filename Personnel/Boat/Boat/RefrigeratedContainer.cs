using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    class RefrigeratedContainer : Container
    {
        private int _id;
        private float _weight;
        private bool _isRefrigerated;
        private string _color;
        public RefrigeratedContainer(int Id, float Weight, bool IsRefrigerated, List<string> Merchandise, string Color) : base(Id, Weight, IsRefrigerated, Merchandise, Color)
        {
            _id = Id;
            _weight = Weight;
            _isRefrigerated = IsRefrigerated;
            _color = Color;

        }
    }
}

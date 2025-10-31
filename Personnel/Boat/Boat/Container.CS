using System.ComponentModel;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Boat
{
    class Container : IContainer
    {
        public int Id => throw new NotImplementedException();

        public float Weight => throw new NotImplementedException();

        public bool IsRefrigerated => throw new NotImplementedException();

        public List<string> Merchandise => throw new NotImplementedException();

        public string Color => throw new NotImplementedException();

        List<Container> container = new List<Container>();

        public Container(int Id, float Weight, bool IsRefrigerated, List<string> Merchandise, string Color)
        {
            
        }

        public void AddMerchandise(string item)
        {
            throw new NotImplementedException();
        }

        public void ViewContent()
        {
            throw new NotImplementedException();
        }
    }

}
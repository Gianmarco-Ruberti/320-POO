using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    class Container : IContainer
    {
        public int Id => throw new NotImplementedException();

        public float Weight => throw new NotImplementedException();

        public bool IsRefrigerated => throw new NotImplementedException();

        public List<string> Merchandise => throw new NotImplementedException();

        public string Color => throw new NotImplementedException();

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
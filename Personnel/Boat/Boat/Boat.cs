using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    class Boat : IBoat
    {
        public string Name => "Titanic";

        public float MaxCargoWeight => 12;

        public int MaxSpeed => 12;

        public bool LoadContainer(IContainer container)
        {
            /*List<Container> container = new List<Container>();
            for (int i = 0; i < MaxCargoWeight; i++)
            {
                Container _container = new Container();
            }
            return container.Count > 0;*/
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public bool UnloadContainer(IContainer container)
        {
            for (int i = 0; ; i++)
            {
            }
        }

    }
}
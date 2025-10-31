using Boat;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main()
        {
            List<string> Merchandise = new List<string>();
            List<RefrigeratedContainer> refrigeratedContainer = new List<RefrigeratedContainer>();
            refrigeratedContainer.Add(new RefrigeratedContainer(1, 400, true, new List<string> {"glace"}, "blanc"));
            refrigeratedContainer.Add(new RefrigeratedContainer(2, 1400, true, new List<string> { "poisson" }, "bleu"));
            refrigeratedContainer.Add(new RefrigeratedContainer(3, 700, true, new List<string> { "Beer" }, "maron"));
        }
    }
}
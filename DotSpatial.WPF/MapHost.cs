using DotSpatial.Controls;
using System.Windows.Forms.Integration;

namespace DotSpatial.WPF
{
    public class MapHost : WindowsFormsHost
    {
        private readonly Map _map;

        public MapHost()
        {
            _map = new Map();
        }
    }
}

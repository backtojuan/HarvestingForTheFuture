using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    /**
     * This class allows to create a zone which is an specied set of areas
     */
    public class Zone
    {
        private List<Area> Areas;

        /**
         * Zone Constructor
         */
        public Zone()
        {
            Areas = new List<Area>();
        }

        /**
         * Adds a new area for this zone
         */
        public void AddArea(Area area)
        {
            Areas.Add(area);
        }

        /**
         * Allows to get all areas on a zone
         */
        public List<Area> GetAreas { get => Areas; }
    }
}

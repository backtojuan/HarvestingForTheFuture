using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    class Zone
    {
        private List<Area> Areas;

        public Zone()
        {

        }

        public void AddArea(Area area)
        {
            Areas.Add(area);
        }

        public List<Area> GetAreas { get => Areas;}
    }
}

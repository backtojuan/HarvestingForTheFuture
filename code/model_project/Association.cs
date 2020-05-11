using project_model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model_project
{
    class Association
    {
        private Zone zone;
        private List<Farming> farmings;
        private List<Relation> relations;

        public Association()
        {

        }

        public Zone GetZone { get => zone; set => zone = value; }
        public List<Farming> GetAreas { get => farmings; set => farmings = value; }
        public List<Relation> GetRelations { get => relations; set => relations = value; }

    }
}

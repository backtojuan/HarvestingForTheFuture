using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    class Association
    {
        private Zone zone;
        private List<Farming> farmings;
        private List<Relation> relations;

        public Association()
        {

        }

        public void association(String department)
        {

        }

        public void loadZone(String departmentRoute)
        {

        }

        public Zone GetZone { get => zone; set => zone = value; }
        public List<Farming> GetFarmings { get => farmings; set => farmings = value; }
        public List<Relation> GetRelations
        {
            get => relations; set => relations = value;
        }
    }
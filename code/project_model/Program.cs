using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    public class Program
    {
        private Analyzer analyzer;
        private Association association;

        public Program() 
        {
            analyzer = new Analyzer();
            association = new Association();
        }

        public Analyzer GetAnalyzer { get => analyzer; set => analyzer = value; }
        public Association GetAssociation { get => association; set => association = value; }
    }
}

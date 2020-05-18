using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    public class Project
    {
		
        private Association association;
        private Analyzer analyzer;
        

        /*
         * Constructor de la clase
         */
        public Project()
        {
            
        }

        /*
         * realiza el pre-procesamiento de datos de la base de datso principal
         * y serializa la información
         */
        public void ActualiceDB()
        {
            analyzer = new Analyzer();
        }

        public void Association(String DepartmentName)
        {
            //association = new Association(DepartmentName);
        }

        /*
         * retorna el nombre del cultivo de la relación creada con el departamento
         * en la posisción entregada por parametro
         */
        public String NameHarvisting(int i)
        {
            //association.getRelations()[i].GetFarming().GetName;
            return "hi";
        }

        /*
         * retorna el porncetaje de compatibilidad del cultivo de la relación creada con el departamento
         * en la posisción entregada por parametro
         */
        public double CompatibilityHarvisting(int i)
        {
            //association.getRelations()[i].GetFarming().GetCompatibility();
            return 1.0;
        }

        public Analyzer GetZone { get => analyzer; set => analyzer = value; }
        public Association GetAssociation { get => association; set => association = value; }

    }
}

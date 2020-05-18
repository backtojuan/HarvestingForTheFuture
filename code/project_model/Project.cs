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

        /*
         * Renorna el tamaño de la lista de Relaciones
         */ 
        public int HarvestingSize()
        {
            return association.GetRelations.Count;
        }

        /*
         * se encarga de realizar la asociacion entre el departamento seleccionado por el usuario y los cultivos
         */
        public void Association(String DepartmentName)
        {
            association = new Association(DepartmentName);
            association.Compare();
        }

        /*
         * retorna el nombre del cultivo de la relación creada con el departamento
         * en la posisción entregada por parametro
         */
        public String NameHarvisting(int i)
        {
            return association.GetRelations[i].GetFarming.GetName; ;
        }

        /*
         * retorna el porncetaje de compatibilidad del cultivo de la relación creada con el departamento
         * en la posisción entregada por parametro
         */
        public double CompatibilityHarvisting(int i)
        {        
            return association.GetRelations[i].GetCompatibility;
        }

        public double GetInfoHumidity(int name)
        {
            return association.GetRelations[name].GetRelativeHumidityPercent;
        }

        public int[] GetInfoHumidityHarv(int Relation)
        {
            return association.GetRelations[Relation].GetFarming.GetRelativeHumidity;
        }

        public Analyzer GetZone { get => analyzer; set => analyzer = value; }
        public Association GetAssociation { get => association; set => association = value; }

    }
}

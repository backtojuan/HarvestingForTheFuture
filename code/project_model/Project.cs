using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    public class Program
    {

        private Association association;
        private Analyzer analyzer;
        

        /*
         * Constructor de la clase
         */
        public Program()
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
    }
}

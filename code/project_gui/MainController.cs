using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_gui;
using project_model;



namespace project_gui
{
    class MainController
    {
        /*
         * Representa la relación con la interfaz FirstPage
         */
        private FirstPage FirstPage;
        /*
         * representa la relación con la interfaz ConsolidatedPage
         */
        private ConsolidatedPage ConsolidatedPage;

        /*
         * representa la relación con el modelo
         */

        private Program program;

        /*
         * representa la relación con el paquete de las descripciones para los detalles de la interfaz
         */
         //private Principal Principal;
         


        /*
         * Constructor del Main controller
         * first es la pagina FirstPage Activa del proyecto
         */
        public MainController(FirstPage first)
        {
            FirstPage = first;
            //program = new Program();
            //Principal = new Principal();
        }

        /*
         * Carga ConsolidatedPage
         * 
         */
        public void LoadConsolidatedPage(String name)
        {
            ConsolidatedPage = new ConsolidatedPage();
            ConsolidatedPage.SetDepartmentLabel(name);
            ConsolidatedPage.ShowDialog();
        }

        /*
         */
          public int HarvestingListSize(String Name)
          {
            
            //ModelProgram.getAssociation.getRelationList(Name).Count;
            return 0;
          }

        /*
         * uno de los metodo que retorna la info para mostrar la info del match
         */
         public String InfoHarvesting(String HarvestingName)
         {
            //traer información del modelo para mostrar la info
            //llamar el metodo de mostrar

            return "Holii";
         }             
    }
}

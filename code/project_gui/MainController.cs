using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using project_model;


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

       // private Program ModelProgram;


        /*
         * Constructor del Main controller
         * first es la pagina FirstPage Activa del proyecto
         */
        public MainController(FirstPage first)
        {
            FirstPage = first;
        }
        /*
         * Carga ConsolidatedPage
         * 
         */
        public void LoadConsolidatedPage()
        {
            ConsolidatedPage = new ConsolidatedPage();
        }

        /*
         */
         
          public int HarvestingListSize(String Name)
          {
            
            //ModelProgram.getAssociation.getRelationList(Name).Count;
            return 0;
          }
        
       


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_gui;
//using project_model;
//using project_model.Program;
//using _DataFirstPage_;


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

        //private Program ModelProgram;

        /*
         * representa la relacion con el modelo de FirstPage
         */

        //private Principal principalFirstPage;

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
             * Metodo que llena la lista del comboBox de la clase FirtsPage
             */

            /*  public List<String> deps(List<String> list)
                {
            list.ElementAt < i > = principalFirstPage.getList().getName();
            }
            */
       


    }
}

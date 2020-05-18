using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_gui;
using project_model;



namespace project_gui
{
    public class MainController
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

        private Project project;

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
            project = new Project();
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
            project.Association(name);
            //load grid de harvestings
            //project.
            ConsolidatedPage.ShowDialog();

        }

        /*
         * carga los datos base de los cultivos en el DataGridView de ConsolidatedPage
         */
        public void LoadGridOfConsolidatedPage()
        {
            for(int i = 0; i < HarvestingListSize(); i++)
            {
                String name = project.NameHarvisting(i);
                double comp = project.CompatibilityHarvisting(i);
                //ConsolidatedPage.AddToDataGridView(i+1, name, comp);
            }

        }

        /*
         */
        public int HarvestingListSize()
          {
            
            //project.getAssociation.getRelationList(Name).Count;
            return 0;
          }

        /*
         * uno de los metodo que retorna la info para mostrar la info del match
         */
         public String InfoHarvesting()
         {
            //traer información del modelo para mostrar la info
            //llamar el metodo de mostrar


            return "Holii";
         }

        public double[] 

        
       


    }
}

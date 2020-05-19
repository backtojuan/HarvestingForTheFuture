using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_model;
using Library;


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
        private Principal Principal;


        /*
         * Constructor del Main controller
         * first es la pagina FirstPage Activa del proyecto
         */
        public MainController(FirstPage first)
        {
            Principal = new Principal();
            project = new Project();
            FirstPage = first;
            LoadDepartmentsCmbFirstPage();

        }

        /*
         * Carga la lista del combobox de departamento en FirstPage
         */
        public void LoadDepartmentsCmbFirstPage()
        {
            List<String> departments = Principal.GetDepartmentsName;
            FirstPage.LoadFirstPage(departments);
        }

        /*
         * Retorna la descripción del depatamento indicado por parametro
         */
        public String GetDepartmentDescription(String departmentName)
        {
            return Principal.GetDepartments[departmentName].GetDescription;
        } 

        /*
         * Retorna el path del departamento indicado por parametro
         */
        public String GetDepartpentPath(String departmentName)
        {
            return Principal.GetDepartments[departmentName].GetPath;
        }

        /*
         * retorna la url de la imagen indicada por parámetro
         */

        public String GetImageDepartament(String departamentName)
        {
            return Principal.GetDepartments[departamentName].GetImage;
        }

        /*
         * Carga ConsolidatedPage
         */
        public void LoadConsolidatedPage(String name)
        {
            ConsolidatedPage = new ConsolidatedPage(this);
            ConsolidatedPage.SetDepartmentLabel(name);
            project.Association(GetDepartpentPath(name));
            //load grid de harvestings
            LoadGridOfConsolidatedPage();
            ConsolidatedPage.ShowDialog();
        }

        /*
         * carga los datos base de los cultivos en el DataGridView de ConsolidatedPage
         */
        public void LoadGridOfConsolidatedPage()
        {
            Console.WriteLine(HarvestingListSize() + "aqui esta el numero");
            for(int i = 0; i < HarvestingListSize(); i++)
            {
                String name = project.NameHarvisting(i);
                double comp = project.CompatibilityHarvisting(i);
                ConsolidatedPage.AddToDataGridView(i+1, name, comp);
                Console.WriteLine(name);
            }
        }

        //Liquid precipitation
        public List<double> GetInfoLiquidPrecipitationEstimations(int Relation)
        {
            return project.GetAssociation.GetRelations[Relation].GetArea.Liquidprecipitationestimations;
        }

        public double GetLiquidPrecipitation(int Relation)
        {
            return project.GetAssociation.GetRelations[Relation].GetFarming.GetLiquidPrecipitation;
        }

        //Relative Humidity
        public List<double> GetInfoChartHumidity(int Relation)
        {
            return project.GetAssociation.GetRelations[Relation].GetArea.Relativehumidityestimations;
        }

        public double[] GetInfoHumidity(int Relation)
        {
            return project.GetAssociation.GetRelations[Relation].GetFarming.GetRelativeHumidity;
        }
        
        //Temperature
        public List<double> GetInfoChartTemperature(int Relation)
        {
            return project.GetAssociation.GetRelations[Relation].GetArea.Temperatureestimations;
        }

        public double GetInfoMaxTemperature(int Relation)
        {
            return project.GetAssociation.GetRelations[Relation].GetFarming.GetMaxTemperature;
        }
        public double GetInfoMinTemperature(int Relation)
        {
            return project.GetAssociation.GetRelations[Relation].GetFarming.GetMinTemperature;
        }

        //Wind Spend
        public List<double> GetInfoChartWindSpeed(int Relation)
        {
            return project.GetAssociation.GetRelations[Relation].GetArea.Windspeedestimations;
        }

        public double GetInfoWindSpeed(int Relation)
        {
            return project.GetAssociation.GetRelations[Relation].GetFarming.GetWindSpeed;
        }


        public double GetLongitude()
        {
            //String Longitude = project.GetAssociation.GetRelations[0].GetArea.Longitude;
            //return Convert.ToDouble(Longitude);
            return -76.5224991;
        }


        public double GetLatitude()
        {
            //String Latitude = project.GetAssociation.GetRelations[0].GetArea.Latitude;
            //return Convert.ToDouble(Latitude);
            return 3.4590000;
        }

        /*
         */
        public int HarvestingListSize()
        {            
            return project.HarvestingSize();
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

        /*
         * Evento, sucede al hacer clic sobre el boton de actualizar
         * actualiza la base de datos, continua con el llamado para el pre-procedamiento
         */
        public void ActualizeDB()
        {
            project.ActualiceDB();
        }


    }
}

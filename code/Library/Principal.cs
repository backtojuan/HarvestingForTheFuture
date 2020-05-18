using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Library
{
    public class Principal
    {
        public const String DEPARTMENTS = "..\\..\\..\\..\\code\\Data\\DATA_FIRST_PAGE\\Departamentos.txt";
        public const String HARVESTINGS = "..\\..\\..\\..\\code\\Data\\DATA_FIRST_PAGE\\Cultivo.txt";
        private List<String> departmentsName;
        private List<String> harvestingsName;
        private Dictionary<String, Department> departments;
        private Dictionary<String, Harvesting> harvestings;


        public Principal()
        {
            departmentsName = new List<String>();
            harvestingsName = new List<String>();
            departments = new Dictionary<String, Department>();
            harvestings = new Dictionary<String, Harvesting>();
            ReadDepartments();
            ReadHarvesting();
        }

        public void ReadDepartments()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(DEPARTMENTS);

                line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    String[] depar = line.Split(';');
                    departmentsName.Add(depar[0]);
                    departments.Add(depar[0], new Department(depar[0], depar[1], depar[2], depar[3]));
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
           

        }

        public void ReadHarvesting()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(HARVESTINGS);

                line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    String[] harv = line.Split(';');
                    harvestingsName.Add(harv[0]);
                    harvestings.Add(harv[0], new Harvesting(harv[0], harv[1]));
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            

        }

        public List<String> GetDepartmentsName { get => departmentsName; set => departmentsName = value; }

        public List<String> GetHarvestingsName { get => harvestingsName; set => harvestingsName = value; }

        public Dictionary<String, Department> GetDepartments { get => departments; set => departments = value; }

        public Dictionary<String, Harvesting> GetHarvestings { get => harvestings; set => harvestings = value; }

    }
}

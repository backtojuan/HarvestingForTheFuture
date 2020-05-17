using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DataFistPage
{
    //Esta clase contiene la lista de departamentos que se agregarán en el comboBox de la clase FirstPage
    class Principal
    {

        public Principal()
        {

        }

        const String DEPARTAMENTS = "..\\..\\..\\..\\code\\Data\\DATA_FIRST_PAGE\\Departament.txt";
        const String CULTIVO = "..\\..\\..\\..\\code\\Data\\DATA_FIRST_PAGE\\Cultivo.txt";

        public List<Departament> departament = new List<Departament>();

        public void Read()
        {
            String line;

            StreamReader sr = new StreamReader(DEPARTAMENTS);

            line = "";

            while ((line = sr.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                String[] depar = line.Split(';');
                departament.Add(new Departament(depar[0], depar[1], depar[2]);
                
            }
        sr.Close();

        }
        
    }
}



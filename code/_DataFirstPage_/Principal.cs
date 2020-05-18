using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace DataFistPage
{
    //Esta clase contiene la lista de departamentos que se agregarán en el comboBox de la clase FirstPage
    class Principal
    {

        const String DEPARTAMENTS = "..\\..\\..\\..\\code\\Data\\DATA_FIRST_PAGE\\Departament.txt";
        const String CULTIVO = "..\\..\\..\\..\\code\\Data\\DATA_FIRST_PAGE\\Cultivo.txt";
        public List<Departament> departament; //new List<Departament>();
        public Dictionary<String, List<Departament>> dictionary; //new Dictionary<String,List<Departament>>();

        public Principal()
        {
            departament = new List<Departament>();
            dictionary = new Dictionary<String, List<Departament>>();

        }

    public void Read()
        {
            
            String line;

            StreamReader sr = new StreamReader(DEPARTAMENTS);

            line = "";

            while ((line = sr.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                String[] depar = line.Split(';');
                departament.Add(new Departament(depar[0], depar[1], depar[2]));

                dictionary.Add(depar[0], departament);
            }
        sr.Close();

        }

       /* public List<String> getList()
        {
            return departament;
        }

        /*
         * Metodo que busca dentro de la tabla el elemento seleccionado delsde el caomboBox en la interfaz
         */

         
          
       /* public void buscar()
        {
            Hashtable table = new Hashtable();

            table.Add(departament[0], depar);

        }*/
        
    }
}



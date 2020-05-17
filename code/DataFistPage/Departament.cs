using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFistPage
{
    //Esta clase contiene la lista de departamentos que se agregarán en el comboBox de la clase FirstPage
    class Departament
    {
        public List<String> list;

        public void AgregarElementos()
        {
            list.Add("Antioquia");
            list.Add("Boyacá");
            list.Add("Cesar");
            list.Add("Choco");
            list.Add("Cundinamarca");
            list.Add("La Guajira");
            list.Add("Magdalena");
            list.Add("Meta");
            list.Add("Santander");
            list.Add("Tolima");
            list.Add("Valle del Cauca");

        }
        public List<String> Getlist { get => list; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataFistPage
{
    class References
    {
        private String name;
        private String description;
        private String image;
        const String DEPARTAMENT = "..\\..\\..\\..\\code\\Data\\DATA_FIRST_PAGE\\Departament.txt";
        const String CULTIVO = "..\\..\\..\\..\\code\\Data\\DATA_FIRST_PAGE\\Cultivo.txt";

       private List<String> departament = new List<String>();
        public void Read()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(DEPARTAMENT);

                line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    String[] info = line.Split(';');
                    departament.Add(new ()
                    {
                        name = info[0],
                        description = info[1],
                        Email = info[2],
                        Celphone = info[3]
                    });

                }

                sr.Close();
                //Console.ReadLine();
                Thread.Sleep(4000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

    }
}

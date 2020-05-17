using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataFistPage
{
    class Departament
    {
        private String name;
        private String description;
        private String image;
        

        public Departament(String name, String description, String image)
        {
            this.name = name;
            this.description = description;
            this.image = image;
        }

        public String GetName { get => name; set => name = value;}

        public String GetDescription { get => description; set => description = value;}

        public String GetImage { get => image; set => image = value; }


    }

}

    


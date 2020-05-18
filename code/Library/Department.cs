using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Department
    {
        private String name;
        private String path;
        private String description;
        private String image;


        public Department(String name, String path, String description, String image)
        {
            this.name = name;
            this.path = path;
            this.description = description;
            this.image = image;
        }

        public String GetName { get => name; set => name = value; }

        public String GetPath { get => path; set => path = value; }

        public String GetDescription { get => description; set => description = value; }

        public String GetImage { get => image; set => image = value; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Harvesting
    {
        private String name;
        private String path;

        public Harvesting(String name, String path)
        {
            this.name = name;
            this.path = path;
        }

        public String GetName { get => name; set => name = value; }
        public String GetPath { get => path; set => path = value; }
    }
}

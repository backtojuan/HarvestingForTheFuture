using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using model;
using Newtonsoft.Json;
using SODA;

namespace model
{
    public class User
    {
        const String URL = "https://www.datos.gov.co/resource/ysq6-ri4e.json";
        private List<Data> data;

        public User() {
            data = new List<Data>();
        }

        public List<Data> GetData()
        {
            return data;
        }

        public void Load()
        {
            string result = "";
            try
            {
                var url = "https://www.datos.gov.co/resource/ysq6-ri4e.json?";
                var client = new WebClient();

                using (var stream = client.OpenRead(url))
                using (var reader = new StreamReader(stream))
                {
                    String line = reader.ReadLine();
                    int count = 0;
                    while ((line = reader.ReadLine()) != null && count <= 10)
                    {
                        String[] args = line.Split(',');
                        Console.WriteLine(args[count]);
                        count++;

                        Data datatype = new Data(args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8], args[9], args[10], args[11], args[12], args[13], args[14]);
                        data.Add(datatype);

                    }
                    reader.Close();
                    stream.Close();
                }

            }
            catch (WebException e)
            {
                result = string.Format("F", e);
                Console.WriteLine(result);
            }
        }
    }
}
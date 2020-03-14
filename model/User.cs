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
        //Constants & Attributes
        const String URL = "https://www.datos.gov.co/resource/ysq6-ri4e.json";
        const String Space = "%20";
        const String Addition = "&";
        const String Limit = "$limit=";
        const String Amount = "$offset=";
        const String Condition = "$where=";
        private List<Data> data;
        private List<String> test;

        public User() {
            data = new List<Data>();
            test = new List<String>();
        }

        public List<String> getTest() {
            return test;
        }

        public List<Data> GetData()
        {
            return data;
        }

        //Reads json as a Text File
        public void Load(int limit, int amount, String json)
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
                    while ((line = reader.ReadLine()) != null && count <= 50)
                    {
                        String[] args = line.Split(',');
                        count++;

                        /*Separates between key & Value (key : value) for every data element and replaces '"' with ' '
                         * to clean the strings */
                        String[] partialDate = args[1].Split(' ');
                        String[] date = partialDate[0].Split(':');
                        String completeDate = date[1].Replace('"',' ') + " " + partialDate[1] + 
                            " " + partialDate[2] + partialDate[3].Replace('"',' ');
                        

                        String[] partialAuthority = args[2].Split(':');
                        String EnviromentalAuthority = partialAuthority[1].Replace('"',' ');

                        String[] partialStation = args[3].Split(':');
                        String StationName = partialStation[1].Replace('"',' ');

                        String[] partialTechnology = args[4].Split(':');
                        String Technology = partialTechnology[1].Replace('"', ' ');

                        String[] partialLatitude = args[5].Split(':');
                        String Latitude = partialLatitude[1].Replace('"', ' ');

                        String[] partialLongitude = args[6].Split(':');
                        String Longitude = partialLongitude[1].Replace('"', ' ');

                        String[] partialDepCode = args[7].Split(':');
                        String DeparmentCode = partialDepCode[1].Replace('"', ' ');

                        String[] partialDepName = args[8].Split(':');
                        String DepartmentName = partialDepName[1].Replace('"', ' ');

                        String[] partialMunCode = args[9].Split(':');
                        String MunicipalityCode = partialMunCode[1].Replace('"', ' ');

                        String[] partialMunName = args[10].Split(':');
                        String MunicipalityName = partialMunName[1].Replace('"', ' ');

                        String[] partialType = args[11].Split(':');
                        String TypeofStation = partialType[1].Replace('"', ' ');

                        String[] partialExhibitionTime = args[12].Split(':');
                        String ExhibitionTime = partialExhibitionTime[1].Replace('"', ' ');

                        String[] partialVariable = args[13].Split(':');
                        String Variable = partialVariable[1].Replace('"', ' ');

                        String[] partialUnits = args[14].Split(':');
                        String Units = partialUnits[1].Replace('"', ' ');

                        String[] partialConcentration = args[15].Split(':');
                        String Concentration = partialConcentration[1].Replace('"', ' ');

                        Data datatype = new Data(completeDate, EnviromentalAuthority, StationName, Technology, Latitude,
                            Longitude, DeparmentCode, DepartmentName, MunicipalityCode, MunicipalityName, TypeofStation,
                            ExhibitionTime, Variable, Units, Concentration);

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
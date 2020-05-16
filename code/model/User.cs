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
    /*
     * This class allows to do a Json file processing for the data set of interest 
     */
    public class User
    {
        //Json location
        public const String URL = "https://www.datos.gov.co/resource/ysq6-ri4e.json?";

        //simple filters
        public const String Space = "%20";
        public const String Addition = "&";
        public const String Limit = "$limit=";
        public const String Amount = "$offset=";
        public const String Condition = "$where=";
        public const String Selected = "$select=";
        private List<Data> data;

        //specified value searched while filtering
        public const String date = "fecha=";
        public const String enviromentalauthority = "autoridad_ambiental=";
        public const String stationname = "nombre_de_la_estaci_n=";
        public const String technology = "tecnolog_a=";
        public const String latitude = "latitud=";
        public const String longitude = "longitud=";
        public const String departmentcode = "c_digo_del_departamento=";
        public const String departmentname = "departamento=";
        public const String municipalitycode = "c_digo_del_municipio=";
        public const String municipalityname = "nombre_del_municipio=";
        public const String typeofstation = "tipo_de_estaci_n=";
        public const String exhibitiontime = "tiempo_de_exposici_n=";
        public const String variable = "variable=";
        public const String units = "unidades=";
        public const String concentration = "concentraci_n=";

        //specified variables of interest
        public const String LP = "Precipitación_Líquida";
        public const String RH = "Humedad_Relativa";
        public const String TMP = "Temperatura";
        public const String WS = "Velocidad_del_viento";

        public String report;

        public String getReport()
        {
            return report;
        }

        /**
         * User Constructor
         * initializes the list that is going to contain every data row
         */
        public User()
        {
            data = new List<Data>();
        }

        /**
         * This method allows to get the list that contains the data rows
         */
        public List<Data> GetData()
        {
            return data;
        }

        /**
         * This method loads the json as a text file and fills the data list with data rows.
         * selected is when only needs to be searched one single column
         * json is the current url where the json can be found
         */
        public void Load(Boolean selected, String json)
        {
            string result = "";
            Data datatype = null;

            try
            {
                var client = new WebClient();

                using (var stream = client.OpenRead(json))
                using (var reader = new StreamReader(stream))
                {
                    String line = reader.ReadLine();
                    int count = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        String[] args = line.Split(',');
                        /*
                         * in the case that the user is asking for the complete data row and its complete values in
                         * every column
                         */
                        if (!selected)
                        {
                            /*
                            * Separates between key & Value (key : value) for every data element and replaces '"' with ' '
                            * to clean the strings 
                            */
                            String[] partialDate = args[1].Split(' ');
                            String[] date = partialDate[0].Split(':');
                            String completeDate = date[1].Replace('"', ' ') + " " + partialDate[1] +
                                " " + partialDate[2] + partialDate[3].Replace('"', ' ');

                            String[] partialAuthority = args[2].Split(':');
                            String EnviromentalAuthority = partialAuthority[1].Replace('"', ' ');

                            String[] partialStation = args[3].Split(':');
                            String StationName = partialStation[1].Replace('"', ' ');

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

                            datatype = new Data(completeDate, EnviromentalAuthority, StationName, Technology, Latitude,
                                Longitude, DeparmentCode, DepartmentName, MunicipalityCode, MunicipalityName, TypeofStation,
                                ExhibitionTime, Variable, Units, Concentration);
                        }
                        /**
                         * in the case that the user is asking for a partial data row and a specified value in a
                         * specified column
                         */
                        else
                        {
                            if (json.Contains(User.Selected + User.date.Replace(User.date.Last(), ' ')))
                            {
                                String[] partialDate = args[1].Split(':');
                                String completeDate = partialDate[1].Substring(1) + " " + partialDate[2] + " "
                                    + partialDate[3].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data(completeDate, "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                            }
                            
                            else if (json.Contains(User.Selected + User.enviromentalauthority.Replace(User.enviromentalauthority.Last(), ' ')))
                            {
                                String[] partialAuthority = args[1].Split(':');
                                String enviromentalAuthority = partialAuthority[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", enviromentalAuthority, "", "", "", "", "", "", "", "", "", "", "", "", "");
                            }
                            
                            else if (json.Contains(User.Selected + User.stationname.Replace(User.stationname.Last(), ' '))) 
                            {
                                String[] partialStationName = args[1].Split(':');
                                String stationName = partialStationName[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "",stationName, "", "", "", "", "", "", "", "", "", "", "", "");
                            }
                            
                            else if (json.Contains(User.Selected + User.technology.Replace(User.technology.Last(), ' ')))
                            {
                                String[] partialTechnology = args[1].Split(':');
                                String technology = partialTechnology[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", technology, "", "", "", "", "", "", "", "", "", "", "");
                            }
                            
                            else if (json.Contains(User.Selected + User.latitude.Replace(User.latitude.Last(), ' ')))
                            {
                                String[] partialLatitude = args[1].Split(':');
                                String latitude = partialLatitude[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", latitude, "", "", "", "", "", "", "", "", "", "");
                            }
                            
                            else if (json.Contains(User.Selected + User.longitude.Replace(User.longitude.Last(), ' ')))
                            {
                                String[] partialLongitude = args[1].Split(':');
                                String longitude = partialLongitude[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", longitude, "", "", "", "", "", "", "", "", "");
                            }
                            
                            else if (json.Contains(User.Selected + User.departmentname.Replace(User.departmentname.Last(), ' ')))
                            {
                                String[] partialDepName = args[1].Split(':');
                                String departmentName = partialDepName[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", "", departmentName, "", "", "", "", "", "", "");
                            }
                            
                            else if (json.Contains(User.Selected + User.departmentcode.Replace(User.departmentcode.Last(), ' ')))
                            {
                                String[] partialDepCode = args[1].Split(':');
                                String departmentCode = partialDepCode[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", departmentCode, "", "", "", "", "", "", "", "");
                            }
                            
                            else if (json.Contains(User.Selected + User.municipalityname.Replace(User.municipalityname.Last(), ' ')))
                            {
                                String[] partialMunName = args[1].Split(':');
                                String municipalityName = partialMunName[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", "","", "", municipalityName, "", "", "", "", "");
                            }
                            
                            else if (json.Contains(User.Selected + User.municipalitycode.Replace(User.municipalitycode.Last(), ' ')))
                            {
                                String[] partialMunCode = args[1].Split(':');
                                String municipalityCode = partialMunCode[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", "", "", municipalityCode, "", "", "", "", "", "");
                            }
                            
                            else if (json.Contains(User.Selected + User.typeofstation.Replace(User.typeofstation.Last(), ' ')))
                            {
                                String[] partialTypeOfStation = args[1].Split(':');
                                String typeOfStation = partialTypeOfStation[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", "", "", "", "" ,typeOfStation, "", "", "", "");
                            }
                            
                            else if (json.Contains(User.Selected + User.exhibitiontime.Replace(User.exhibitiontime.Last(), ' ')))
                            {
                                String[] partialExhibitionTime = args[1].Split(':');
                                String exhibitionTime = partialExhibitionTime[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", "", "", "", "", "", exhibitionTime, "", "", "");
                            }

                            else if (json.Contains(User.Selected + User.variable.Replace(User.variable.Last(), ' ')))
                            {
                                String[] partialVariable = args[1].Split(':');
                                String variable = partialVariable[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", "", "", "", "", "", "", variable, "", "");
                            }

                            else if (json.Contains(User.Selected + User.units.Replace(User.units.Last(), ' ')))
                            {
                                String[] partialUnits = args[1].Split(':');
                                String units = partialUnits[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", "", "", "", "", "", "", "", units, "");
                            }

                            else if (json.Contains(User.Selected + User.concentration.Replace(User.concentration.Last(), ' ')))
                            {
                                String[] partialConcentration = args[1].Split(':');
                                String concentration = partialConcentration[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", "", "", "", "", "", "", "", "", concentration);
                            }
                        }
                        data.Add(datatype);
                        count++;
                    }
                    reader.Close();
                    stream.Close();
                }

            }
            catch (WebException webexception)
            {
                result = string.Format("No se pudo cargar el json", webexception);
                Console.Write(result);
            }
        }

        /**
         * This method loads the json as a text file and fills the data list with data rows.
         * selected is for the case that one single column was selected to be shown
         * limit is the maximum number of data requested
         * json is the current url where the json can be found
         */
        public void Load(Boolean selected, double amount, String json)
        {
            string result = "";
            Data datatype = null;

            try
            {
                var client = new WebClient();

                using (var stream = client.OpenRead(json))
                using (var reader = new StreamReader(stream))
                {

                    String line = reader.ReadLine();
                    int count = 0;
                    while ((line = reader.ReadLine()) != null && count < amount)
                    {
                        String[] args = line.Split(',');
                        /*
                         * in the case that the user is asking for the complete data row and its complete values in
                         * every column
                         */
                        if (!selected)
                        {
                            /*
                            * Separates between key & Value (key : value) for every data element and replaces '"' with ' '
                            * to clean the strings 
                            */
                            String[] partialDate = args[1].Split(' ');
                            String[] date = partialDate[0].Split(':');
                            String completeDate = date[1].Replace('"', ' ') + " " + partialDate[1] +
                                " " + partialDate[2] + partialDate[3].Replace('"', ' ');

                            String[] partialAuthority = args[2].Split(':');
                            String EnviromentalAuthority = partialAuthority[1].Replace('"', ' ');

                            String[] partialStation = args[3].Split(':');
                            String StationName = partialStation[1].Replace('"', ' ');

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

                            datatype = new Data(completeDate, EnviromentalAuthority, StationName, Technology, Latitude,
                                Longitude, DeparmentCode, DepartmentName, MunicipalityCode, MunicipalityName, TypeofStation,
                                ExhibitionTime, Variable, Units, Concentration);
                        }
                        /**
                         * in the case that the user is asking for a partial data row and a specified value in a
                         * specified column
                         */
                        else
                        {
                            if (json.Contains(User.Selected + User.date.Replace(User.date.Last(), ' ')))
                            {
                                String[] partialDate = args[1].Split(':');
                                String completeDate = partialDate[1].Substring(1) + " " + partialDate[2] + " "
                                    + partialDate[3].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data(completeDate, "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                            }

                            else if (json.Contains(User.Selected + User.enviromentalauthority.Replace(User.enviromentalauthority.Last(), ' ')))
                            {
                                String[] partialAuthority = args[1].Split(':');
                                String enviromentalAuthority = partialAuthority[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", enviromentalAuthority, "", "", "", "", "", "", "", "", "", "", "", "", "");
                            }

                            else if (json.Contains(User.Selected + User.stationname.Replace(User.stationname.Last(), ' ')))
                            {
                                String[] partialStationName = args[1].Split(':');
                                String stationName = partialStationName[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", stationName, "", "", "", "", "", "", "", "", "", "", "", "");
                            }

                            else if (json.Contains(User.Selected + User.technology.Replace(User.technology.Last(), ' ')))
                            {
                                String[] partialTechnology = args[1].Split(':');
                                String technology = partialTechnology[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", technology, "", "", "", "", "", "", "", "", "", "", "");
                            }

                            else if (json.Contains(User.Selected + User.latitude.Replace(User.latitude.Last(), ' ')))
                            {
                                String[] partialLatitude = args[1].Split(':');
                                String latitude = partialLatitude[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", latitude, "", "", "", "", "", "", "", "", "", "");
                            }

                            else if (json.Contains(User.Selected + User.longitude.Replace(User.longitude.Last(), ' ')))
                            {
                                String[] partialLongitude = args[1].Split(':');
                                String longitude = partialLongitude[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", longitude, "", "", "", "", "", "", "", "", "");
                            }

                            else if (json.Contains(User.Selected + User.departmentname.Replace(User.departmentname.Last(), ' ')))
                            {
                                String[] partialDepName = args[1].Split(':');
                                String departmentName = partialDepName[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", "", departmentName, "", "", "", "", "", "", "");
                            }

                            else if (json.Contains(User.Selected + User.departmentcode.Replace(User.departmentcode.Last(), ' ')))
                            {
                                String[] partialDepCode = args[1].Split(':');
                                String departmentCode = partialDepCode[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", departmentCode, "", "", "", "", "", "", "", "");
                            }

                            else if (json.Contains(User.Selected + User.municipalityname.Replace(User.municipalityname.Last(), ' ')))
                            {
                                String[] partialMunName = args[1].Split(':');
                                String municipalityName = partialMunName[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", "", "", "", municipalityName, "", "", "", "", "");
                            }

                            else if (json.Contains(User.Selected + User.municipalitycode.Replace(User.municipalitycode.Last(), ' ')))
                            {
                                String[] partialMunCode = args[1].Split(':');
                                String municipalityCode = partialMunCode[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", "", "", municipalityCode, "", "", "", "", "", "");
                            }

                            else if (json.Contains(User.Selected + User.typeofstation.Replace(User.typeofstation.Last(), ' ')))
                            {
                                String[] partialTypeOfStation = args[1].Split(':');
                                String typeOfStation = partialTypeOfStation[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", "", "", "", "", typeOfStation, "", "", "", "");
                            }

                            else if (json.Contains(User.Selected + User.exhibitiontime.Replace(User.exhibitiontime.Last(), ' ')))
                            {
                                String[] partialExhibitionTime = args[1].Split(':');
                                String exhibitionTime = partialExhibitionTime[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", "", "", "", "", "", exhibitionTime, "", "", "");
                            }

                            else if (json.Contains(User.Selected + User.variable.Replace(User.variable.Last(), ' ')))
                            {
                                String[] partialVariable = args[1].Split(':');
                                String variable = partialVariable[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", "", "", "", "", "", "", variable, "", "");
                            }

                            else if (json.Contains(User.Selected + User.units.Replace(User.units.Last(), ' ')))
                            {
                                String[] partialUnits = args[1].Split(':');
                                String units = partialUnits[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", "", "", "", "", "", "", "", units, "");
                            }

                            else if (json.Contains(User.Selected + User.concentration.Replace(User.concentration.Last(), ' ')))
                            {
                                String[] partialConcentration = args[1].Split(':');
                                String concentration = partialConcentration[1].Replace('"', ' ').Replace('}', ' ').Replace(']', ' ');
                                datatype = new Data("", "", "", "", "", "", "", "", "", "", "", "", "", "", concentration);
                            }
                        }
                        data.Add(datatype);
                        count++;
                    }
                    reader.Close();
                    stream.Close();
                }
            }
            catch (WebException webexception)
            {
                result = string.Format("No se pudo cargar el json", webexception);
                Console.Write(result);
            }
        }
    }
}
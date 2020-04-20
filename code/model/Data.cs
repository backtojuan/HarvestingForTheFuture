using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace model
{

    public class Data
    {
        /**
         * Each attribute represents an specific column, and all columns represent one single row
         */
        private string Date;
        private string EnvironmentalAuthority;
        private string StationName;
        private string Technology;
        private string Latitude;
        private string Longitude;
        private string DepartmentCode;
        private string DepartmentName;
        private string MunicipalityCode;
        private string MunicipalityName;
        private string TypeofStation;
        private string ExhibitionTime;
        private string Variable;
        private string Units;
        private string Concentration;


        /**
         * This method allows to return an specific data row composed by every value in its respective column
         */
        public Data(string Date, string EnvironmentalAuthority, string StationName, string Technology, string Latitude, 
            string Longitude, string DepartmentCode, string DepartmentName, string MunicipalityCode, string MunicipalityName,
            string TypeofStation, string ExhibitionTime, string Variable, string Units, string Concentration)
        {
            this.Date = Date;
            this.EnvironmentalAuthority = EnvironmentalAuthority;
            this.StationName = StationName;
            this.Technology = Technology;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.DepartmentCode = DepartmentCode;
            this.DepartmentName = DepartmentName;
            this.MunicipalityCode = MunicipalityCode;
            this.MunicipalityName = MunicipalityName;
            this.TypeofStation = TypeofStation;
            this.ExhibitionTime = ExhibitionTime;
            this.Variable = Variable;
            this.Units = Units;
            this.Concentration = Concentration;
        }

        /**
         * allows to get the value saved at that specified column for the current data row
         */
        public string GetDate { get => Date; set => Date = value; }
        public string GetEnvironmentalAuthority { get => EnvironmentalAuthority; set => EnvironmentalAuthority = value; }
        public string GetStationName { get => StationName; set => StationName = value; }
        public string GetTechnology { get => Technology; set => Technology = value; }
        public string GetLatitude { get => Latitude; set => Latitude = value; }
        public string GetLongitude { get => Longitude; set => Longitude = value; }
        public string GetDepartmentCode { get => DepartmentCode; set => DepartmentCode = value; }
        public string GetDepartmentName { get => DepartmentName; set => DepartmentName = value; }
        public string GetMunicipalityCode { get => MunicipalityCode; set => MunicipalityCode = value; }
        public string GetMunicipalityName { get => MunicipalityName; set => MunicipalityName = value; }
        public string GetTypeofStation { get => TypeofStation; set => TypeofStation = value; }
        public string GetExhibitionTime { get => ExhibitionTime; set => ExhibitionTime = value; }
        public string GetVariable { get => Variable; set => Variable = value; }
        public string GetUnits { get => Units; set => Units = value; }
        public string GetConcentration { get => Concentration; set => Concentration = value; }

        /**
         * Allows to get a report of the values for the current data row
         */
        public String toString()
        {
            return "Date: " + Date + " Authority: " + EnvironmentalAuthority + " Station: " + StationName + 
                " Tech: " + Technology + " Latitude: " + Latitude + " Longitude: " + Longitude +
                " DepCode: " + DepartmentCode + " DepName: " + DepartmentName + " MunCode: " + MunicipalityCode + 
                " MunName: " + MunicipalityName + " TypeStation " + TypeofStation + " ExhTime: " + ExhibitionTime +
                " Var: " + Variable + " Units: " + Units + " Concentration: " + Concentration + "\n" + "\n";
        }
    }

}
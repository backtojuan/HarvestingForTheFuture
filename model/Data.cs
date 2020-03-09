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
        //Each attribute represents an specific column
        private string Date;
        private string EnvironmentalAuthority;
        private string StationName;
        private string Tecnology;
        private string Latitude;
        private string Length;
        private string DepartmentCode;
        private string Department;
        private string MunicipalityCode;
        private string MunicipalityName;
        private string TypeOfStation;
        private string ExhibithionTime;
        private string Variable;
        private string Units;
        private string Concentration;


        //This method allows to return an specific query
        public Data(string Date, string EnvironmentalAuthority, string StationName, string Tecnology, string Latitude, string Length,
                string DepartmentCode, string Department, string MunicipalityCode, string MunicipalityName, string TypeOfStation, string ExhibithionTime,
               string Variable, string Units, string Concentration)
        {
            this.Date = Date;
            this.EnvironmentalAuthority = EnvironmentalAuthority;
            this.StationName = StationName;
            this.Tecnology = Tecnology;
            this.Latitude = Latitude;
            this.Length = Length;
            this.DepartmentCode = DepartmentCode;
            this.Department = Department;
            this.MunicipalityCode = MunicipalityCode;
            this.MunicipalityName = MunicipalityName;
            this.TypeOfStation = TypeOfStation;
            this.ExhibithionTime = ExhibithionTime;
            this.Variable = Variable;
            this.Units = Units;
            this.Concentration = Concentration;
        }

        public string GetDate { get => Date; set => Date = value; }
        public string GetEnvironmentalAuthority { get => EnvironmentalAuthority; set => EnvironmentalAuthority = value; }
        public string GetStationName { get => StationName; set => StationName = value; }
        public string GetTecnology { get => Tecnology; set => Tecnology = value; }
        public string GetLatitude { get => Latitude; set => Latitude = value; }
        public string GetLength { get => Length; set => Length = value; }
        public string GetDepartmentCode { get => DepartmentCode; set => DepartmentCode = value; }
        public string GetDepartment { get => Department; set => Department = value; }
        public string GetMunicipalityCode { get => MunicipalityCode; set => MunicipalityCode = value; }
        public string GetMunicipalityName { get => MunicipalityName; set => MunicipalityName = value; }
        public string GetTypeOfStation { get => TypeOfStation; set => TypeOfStation = value; }
        public string GetExhibithionTime { get => ExhibithionTime; set => ExhibithionTime = value; }
        public string GetVariable { get => Variable; set => Variable = value; }
        public string GetUnits { get => Units; set => Units = value; }
        public string GetConcentration { get => Concentration; set => Concentration = value; }


        public String toString()
        {
            return Date + EnvironmentalAuthority + StationName + Tecnology + Latitude + Latitude + Length + DepartmentCode + Department + MunicipalityCode + MunicipalityName + TypeOfStation
                + ExhibithionTime + Variable + Units + Concentration;
        }
    }

}
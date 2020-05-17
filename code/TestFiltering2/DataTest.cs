using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFiltering2
{
    [TestClass]
    public class DataTest
    {
        private model.Data Data;

        protected void SetupStage1()
        {
            Data = new model.Data("09 / 04 / 2011 12:00:00 a.m.", "AMVA", "BAR-Hosp. S.V. Paul", "Manual", "6.436",
           "-75.333431", "5", "ANTIOQUIA", "5079", "BARBOSA", "Fija", "24", "PM10", "µg/m3", "55.57");
        }

        [TestMethod]
        public void GetDateTest()
        {
            SetupStage1();

            String ExpectedValue = "09 / 04 / 2011 12:00:00 a.m.";
            Assert.AreEqual(ExpectedValue, Data.GetDate, null, "The date should be: " + ExpectedValue + " but it is " + Data.GetDate);
            Assert.IsNotNull(Data.GetDate, "Warning the value is null !!!");
        }

        [TestMethod]
        public void GetEnvironmentalAuthorityTest()
        {
            SetupStage1();

            String ExpectedValue = "AMVA";
            Assert.AreEqual(ExpectedValue, Data.GetEnvironmentalAuthority, null, "The enviromental authority should be: " + ExpectedValue + " but it is " + Data.GetEnvironmentalAuthority);
            Assert.IsNotNull(Data.GetEnvironmentalAuthority, "Warning the value is null !!!");
        }

        [TestMethod]
        public void GetStationNameTest()
        {
            SetupStage1();

            String ExpectedValue = "BAR-Hosp. S.V. Paul";
            Assert.AreEqual(ExpectedValue, Data.GetStationName, null, "The station name should be: " + ExpectedValue + " but it is " + Data.GetStationName);
            Assert.IsNotNull(Data.GetStationName, "Warning the value is null !!!");
        }

        [TestMethod]
        public void GetTechnologyTest()
        {
            SetupStage1();

            String ExpectedValue = "Manual";
            Assert.AreEqual(ExpectedValue, Data.GetTechnology, null, "The tecnology should be: " + ExpectedValue + " but it is " + Data.GetTechnology);
            Assert.IsNotNull(Data.GetStationName, "Warning the value is null !!!");
        }

        [TestMethod]
        public void GetLatitudeTest()
        {
            SetupStage1();

            String ExpectedValue = "6.436";
            Assert.AreEqual(ExpectedValue, Data.GetLatitude, null, "The latitude should be: " + ExpectedValue + " but it is " + Data.GetLatitude);
            Assert.IsNotNull(Data.GetLatitude, "Warning the value is null !!!");
        }

        [TestMethod]
        public void GetLongitudeTest()
        {
            SetupStage1();

            String ExpectedValue = "-75.333431";
            Assert.AreEqual(ExpectedValue, Data.GetLongitude, null, "The longitude should be: " + ExpectedValue + " but it is " + Data.GetLongitude);
            Assert.IsNotNull(Data.GetLongitude, "Warning the value is null !!!");
        }

        [TestMethod]
        public void GetDepartmentCodeTest()
        {
            SetupStage1();

            String ExpectedValue = "5";
            Assert.AreEqual(ExpectedValue, Data.GetDepartmentCode, null, "The department code should be: " + ExpectedValue + " but it is " + Data.GetDepartmentCode);
            Assert.IsNotNull(Data.GetDepartmentCode, "Warning the value is null !!!");
        }

        [TestMethod]
        public void GetDepartmentNameTest()
        {
            SetupStage1();

            String ExpectedValue = "ANTIOQUIA";
            Assert.AreEqual(ExpectedValue, Data.GetDepartmentName, null, "The department name should be: " + ExpectedValue + " but it is " + Data.GetDepartmentName);
            Assert.IsNotNull(Data.GetDepartmentName, "Warning the value is null !!!");
        }

        [TestMethod]
        public void GetMunicipalityCodeTest()
        {
            SetupStage1();

            String ExpectedValue = "5079";
            Assert.AreEqual(ExpectedValue, Data.GetMunicipalityCode, null, "The municipality code should be: " + ExpectedValue + " but it is " + Data.GetMunicipalityCode);
            Assert.IsNotNull(Data.GetMunicipalityCode, "Warning the value is null !!!");
        }

        [TestMethod]
        public void GetMunicipalityNameTest()
        {
            SetupStage1();

            String ExpectedValue = "BARBOSA";
            Assert.AreEqual(ExpectedValue, Data.GetMunicipalityName, null, "The municipality name should be: " + ExpectedValue + " but it is " + Data.GetMunicipalityName);
            Assert.IsNotNull(Data.GetMunicipalityName, "Warning the value is null !!!");
        }

        [TestMethod]
        public void GetTypeofStationTest()
        {
            SetupStage1();

            String ExpectedValue = "Fija";
            Assert.AreEqual(ExpectedValue, Data.GetTypeofStation, null, "The type of station should be: " + ExpectedValue + " but it is " + Data.GetTypeofStation);
            Assert.IsNotNull(Data.GetTypeofStation, "Warning the value is null !!!");
        }

        [TestMethod]
        public void GetExhibitionTimeTest()
        {
            SetupStage1();

            String ExpectedValue = "24";
            Assert.AreEqual(ExpectedValue, Data.GetExhibitionTime, null, "The exhibition time should be: " + ExpectedValue + " but it is " + Data.GetExhibitionTime);
            Assert.IsNotNull(Data.GetExhibitionTime, "Warning the value is null !!!");
        }

        [TestMethod]
        public void GetVariableTest()
        {
            SetupStage1();

            String ExpectedValue = "PM10";
            Assert.AreEqual(ExpectedValue, Data.GetVariable, null, "The variable should be: " + ExpectedValue + " but it is " + Data.GetVariable);
            Assert.IsNotNull(Data.GetVariable, "Warning the value is null !!!");
        }

        [TestMethod]
        public void GetUnitsTest()
        {
            SetupStage1();

            String ExpectedValue = "µg/m3";
            Assert.AreEqual(ExpectedValue, Data.GetUnits, null, "The units should be: " + ExpectedValue + " but it is " + Data.GetUnits);
            Assert.IsNotNull(Data.GetUnits, "Warning the value is null !!!");
        }

        [TestMethod]
        public void GetConcentrationTest()
        {
            SetupStage1();

            String ExpectedValue = "55.57";
            Assert.AreEqual(ExpectedValue, Data.GetConcentration, null, "The concentration should be: " + ExpectedValue + " but it is " + Data.GetConcentration);
            Assert.IsNotNull(Data.GetConcentration, "Warning the value is null !!!");
        }
    }
}
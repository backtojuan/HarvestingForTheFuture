using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFiltering2
{
    [TestClass]
    public class UserTest
    {
        private model.User User;

        protected void SetupStage1()
        {
            User = new model.User();
        }

        protected void SetupStage2()
        {
            SetupStage1();

            User.GetData().Add(new model.Data("09 / 04 / 2011 12:00:00 a.m.", "AMVA", "BAR-Hosp. S.V. Paul", "Manual", "6.436",
           "-75.333431", "5", "ANTIOQUIA", "5079", "BARBOSA", "Fija", "24", "PM10", "µg/m3", "55.57"));

            User.GetData().Add(new model.Data("13 / 04 / 2011 12:00:00 a. m.", "AMVA", "BAR-Hosp. S.V. Paul", "Manual", "6.436",
           "-75.333431", "5", "ANTIOQUIA", "5079", "BARBOSA", "Fija", "24", "PM10", "µg/m3", "30.81"));

            User.GetData().Add(new model.Data("11 / 04 / 2013 05:00:00 p.m.", "AMVA", "BAR-Parque Las Aguas", "Automática", "6.409306",
          "-75.417306", "5", "ANTIOQUIA", "5079", "BARBOSA", "Fija", "1", "Dirección del Viento", "°", "60.7"));

            User.GetData().Add(new model.Data("12 / 04 / 2013 02:00:00 a. m.", "AMVA", "BAR-Parque Las Aguas", "Automática", "6.409306",
          "-75.417306", "5", "ANTIOQUIA", "5079", "BARBOSA", "Fija", "1", "Dirección del Viento", "°", "261.8"));
        }


        [TestMethod]
        public void FirstTest()
        {
            SetupStage1();

            Assert.IsNotNull(User, "User was not created, its value is null");
        }

        [TestMethod]
        public void GetDataTest()
        {
            SetupStage1();

            int Size = User.GetData().Count;

            Assert.AreEqual(0, Size, null, "The list should be empty right after initializing the User class");
        }

        [TestMethod]
        public void GetDataTest2()
        {
            SetupStage2();

            int Size = User.GetData().Count;

            Assert.AreEqual(4, Size, null, "The list should have 4 Data type objects");
        }

        [TestMethod]
        public void LoadTest1()
        {
            SetupStage2();

            User.Load(false, "https://www.datos.gov.co/resource/ysq6-ri4e.json?");

            foreach (model.Data user in User.GetData())
            {
                Assert.IsNotNull(user.GetDate, "This value should not be null");
                Assert.IsNotNull(user.GetConcentration, "This value should not be null");
                Assert.IsNotNull(user.GetDepartmentCode, "This value should not be null");
                Assert.IsNotNull(user.GetDepartmentName, "This value should not be null");
                Assert.IsNotNull(user.GetEnvironmentalAuthority, "This value should not be null");
                Assert.IsNotNull(user.GetExhibitionTime, "This value should not be null");
                Assert.IsNotNull(user.GetLatitude, "This value should not be null");
                Assert.IsNotNull(user.GetLongitude, "This value should not be null");
                Assert.IsNotNull(user.GetMunicipalityCode, "This value should not be null");
                Assert.IsNotNull(user.GetMunicipalityName, "This value should not be null");
                Assert.IsNotNull(user.GetStationName, "This value should not be null");
                Assert.IsNotNull(user.GetTechnology, "This value should not be null");
                Assert.IsNotNull(user.GetTypeofStation, "This value should not be null");
                Assert.IsNotNull(user.GetUnits, "This value should not be null");
                Assert.IsNotNull(user.GetVariable, "This value should not be null");
            }
        }
    }
}
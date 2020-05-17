using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSirecpa2
{
    [TestClass]
    public class ZoneTest
    {
        protected project_model.Zone Zone;

        protected void SetupStage1()
        {
            Zone = new project_model.Zone();
        }


        [TestMethod]
        public void AddAreaTest()
        {
            SetupStage1();

            project_model.Area Area = new project_model.Area("nombre", 12.0, 13.0, 25.0, 3.0, 45.0, 40.0, 37.0, 2.7);

            Zone.AddArea(Area);

            Assert.IsNotNull(Zone.GetAreas, "The list should not be null");

            Assert.AreEqual(Area.GetName, Zone.GetAreas[0].GetName, null, "The name should be nombre but actually is " + Zone.GetAreas[0].GetName);
            Assert.AreEqual(Area.GetLiquidPrecipitation, Zone.GetAreas[0].GetLiquidPrecipitation, null,"The liquid precipitacion should be 12 but actually is " + Zone.GetAreas[0].GetLiquidPrecipitation);
            Assert.AreEqual(Area.GetRelativeHumidity, Zone.GetAreas[0].GetRelativeHumidity, null, "The relative humidity should be 13 but actually is " + Zone.GetAreas[0].GetRelativeHumidity);
            Assert.AreEqual(Area.GetTemperature, Zone.GetAreas[0].GetTemperature, null, "The temperature should be 25 but actually is " + Zone.GetAreas[0].GetTemperature);
            Assert.AreEqual(Area.GetWindSpeed, Zone.GetAreas[0].GetWindSpeed, null, "The wind speed should be 3 but actually is " + Zone.GetAreas[0].GetWindSpeed);
            Assert.AreEqual(Area.GetiquidPrecipitationConfidence, Zone.GetAreas[0].GetiquidPrecipitationConfidence, null, "The liquid precipitation confidence should be 45 but actually is " + Zone.GetAreas[0].GetiquidPrecipitationConfidence);
            Assert.AreEqual(Area.GetRelativeHumidityConfidence, Zone.GetAreas[0].GetRelativeHumidityConfidence, null, "The relative humidity confidence should be 40 but actually is " + Zone.GetAreas[0].GetRelativeHumidityConfidence);
            Assert.AreEqual(Area.GetTemperatureConfidence, Zone.GetAreas[0].GetTemperatureConfidence, null, "The temperature confidence should be 37 but actually is " + Zone.GetAreas[0].GetTemperatureConfidence);
            Assert.AreEqual(Area.GetWindspeedConfidence, Zone.GetAreas[0].GetWindspeedConfidence, null, "The wind speed confidence should be 2.7 but actually is " + Zone.GetAreas[0].GetWindspeedConfidence);    
        }
    }
}

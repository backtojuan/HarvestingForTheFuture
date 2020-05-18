using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSirecpa2
{
    [TestClass]
    public class AreaTest
    {
        protected project_model.Area Area;

        protected void SetupStage1()
        {
            Area = new project_model.Area("nombre", 12.0, 13.0, 25.0, 3.0, 45.0, 40.0, 37.0, 2.7);
        }
        [TestMethod]
        public void FirstTest()
        {
            SetupStage1();

            Assert.IsNotNull(Area);

            Assert.AreEqual(Area.GetName, "nombre", null, "The name should be nombre");
            Assert.AreEqual(Area.GetLiquidPrecipitation, 12, null, "The liquid precipitation should be 12");
            Assert.AreEqual(Area.GetRelativeHumidity, 13, null, "The relative humidity should be 13");
            Assert.AreEqual(Area.GetTemperature, 25, null, "The temperature should be 25");
            Assert.AreEqual(Area.GetWindSpeed, 3, null, "The wind speed should be 3");
            Assert.AreEqual(Area.GetLiquidPrecipitationConfidence, 45, null, "The liquid precipitation confidence should be 45");
            Assert.AreEqual(Area.GetRelativeHumidityConfidence, 40, null, "The relative humidity confidence should be 40");
            Assert.AreEqual(Area.GetTemperatureConfidence, 37, null, "The temperature confidence should be 37");
            Assert.AreEqual(Area.GetWindspeedConfidence, 2.7, null, "The wind speed confidence should be 2.7");
        }
    }
}

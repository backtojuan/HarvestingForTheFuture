using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSirecpa2
{
    [TestClass]
    public class FarmingrTest
    {
        protected project_model.Farming Farming;

        protected void SetupStage1()
        {
            int[] array = new int[2];
            array[0] = 12;
            array[1] = 14;
            Farming = new project_model.Farming("nombre", 12,array,3,20,30);
        }

        [TestMethod]
        public void FirstTest()
        {
            SetupStage1();

            Assert.AreEqual("nombre", Farming.GetName, null, "The name should be nombre");
            Assert.AreEqual(12, Farming.GetLiquidPrecipitation, null, "The liquid precipitation should be 12");
            Assert.AreEqual(3, Farming.GetWindSpeed,null, "The wind speed should be 3");
            Assert.AreEqual(20, Farming.GetMinTemperature, null, "The min temperature should be 20");
            Assert.AreEqual(30, Farming.GetMaxTemperature, null, "The max temperature should be 30");
            Assert.AreEqual(12,Farming.GetRelativeHumidity[0], null, "The value should be 12");
            Assert.AreEqual(14, Farming.GetRelativeHumidity[1], null, "The value should be 14");
        }
    }
}

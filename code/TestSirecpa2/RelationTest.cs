using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSirecpa2
{
    [TestClass]
    public class RelationTest
    {
        protected project_model.Relation Relation;
        protected project_model.Area Area;
        protected project_model.Farming Farming;


        protected void SetupStage1()
        {
            SetupStage2();
            double[] RelativeHumidityPercent = new double[2];
            RelativeHumidityPercent[0] = 19;
            RelativeHumidityPercent[1] = 20;

            double[] TemperaturePercent = new double[2];
            TemperaturePercent[0] = 31;
            TemperaturePercent[1] = 27;

            Relation = new project_model.Relation("blue", 75, RelativeHumidityPercent, TemperaturePercent, 60, Area, Farming);
        }

        protected void SetupStage2()
        {
            int[] array = new int[2];
            array[0] = 12;
            array[1] = 14;
            Area = new project_model.Area("area", 12.0, 13.0, 25.0, 3.0, 45.0, 40.0, 37.0, 2.7);
            Farming = new project_model.Farming("farming", 12, array, 3, 20, 30);
        }


        [TestMethod]
        public void FirstTest()
        {
            SetupStage1();

            Assert.AreEqual("blue", Relation.GetColor, null, "The color should be blue");
            Assert.AreEqual(75, Relation.GetLiquidPrecipiationPercent, null, "The liquid precipitation should be 75");
            Assert.AreEqual(60, Relation.GetWindSpeedPercent, null, "The wind speed percent should be 60");
            Assert.IsNotNull(Relation.GetFarming, "Farming should not be null");
            Assert.IsNotNull(Relation.GetArea, "Area should not be null");
            Assert.IsNotNull(Relation.GetRelativeHumidityPercent, "RelativeHumidityPercent should not be null");
            Assert.IsNotNull(Relation.GetTemperaturePercent, "TemperaturePercent should not be null");
        }
    }
}

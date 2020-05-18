using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSirecpa2
{
    [TestClass]
    public class ProgramTest
    {
        protected project_model.Program Program;

        protected void SetupStage1()
        {
            Program = new project_model.Program();
        }


        [TestMethod]
        public void FirstTest()
        {
            SetupStage1();

            Assert.IsNotNull(Program.GetAnalyzer);
            Assert.IsNotNull(Program.GetAssociation);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO.JobTests
{
    [TestClass]
    public class JobTests
    {
        /*
        [TestMethod()]
        public void JobTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void JobTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EqualsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EqualsTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            Assert.Fail();
        }
        */

        [TestMethod]
        private void TestSettingJobId()
        {
            Job test_job = new Job();
            Job test_jobTwo = new Job();
            Assert.IsTrue((test_job.Id + 1) == test_jobTwo.Id);
        }


        [TestMethod]
        private void TestJobConstructorSetsAllFields()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"),new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            /*public Job(string name, Employer EmployerName, Location EmployerLocation, PositionType JobType, CoreCompetency JobCoreCompetency)*/
            Assert.AreEqual("Product tester", test_job.Name);
            Assert.AreEqual("ACME", test_job.EmployerName.ToString());
            Assert.AreEqual("Desert", test_job.EmployerLocation.ToString());
            Assert.AreEqual("Quality Control", test_job.JobType.ToString());
            Assert.AreEqual("Persistence", test_job.JobCoreCompetency.ToString());
        }

        [TestMethod]
        private void TestJobsForEquality()
        {
         Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
         Job test_jobtwo = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
         Assert.IsFalse(test_job.Equals(test_jobtwo));
        }

        [TestMethod]
        private void TestJobToString()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            string checkedValue = $"ID: {test_job.Id} \n Name: {test_job.Name} \n Employer: {test_job.EmployerName} \n Location: {test_job.EmployerLocation} \n Position Type: {test_job.JobType} \n Core Compentency: {test_job.JobCoreCompetency}";
            Assert.AreEqual(checkedValue, test_job.ToString());
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTest
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Employer marine_corps = new Employer("Marine Corps");
            Location virginia = new Location("Virgina");
            PositionType sre = new PositionType("SRE");
            CoreCompetency data = new CoreCompetency("Data");            

            Job test_job = new Job("Daryn", marine_corps, virginia, sre, data);
            Job test_job2 = new Job("Daryn", marine_corps, virginia, sre, data);

            Assert.AreNotEqual(test_job2.JobId, test_job.JobId);
            Assert.IsTrue(test_job2.JobId - test_job.JobId == 1);

        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            
            Employer acme = new Employer("ACME");
            Location desert = new Location("Desert");
            PositionType quality_control = new PositionType("Quality control");
            CoreCompetency persistence = new CoreCompetency("Persistence");

            Job test_job3 = new Job("Product Tester", acme, desert, quality_control, persistence);

            Assert.IsTrue(test_job3.Name == "Product Tester");
            Assert.IsTrue(test_job3.EmployerName.Value == "ACME");
            Assert.IsTrue(test_job3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(test_job3.JobType.Value == "Quality control");
            Assert.IsTrue(test_job3.JobCoreCompetency.Value == "Persistence");

        }

        [TestMethod]
        public void TestJobsForEquality()  
        {

            Employer marine_corps = new Employer("Marine Corps");
            Location virginia = new Location("Virgina");
            PositionType sre = new PositionType("SRE");
            CoreCompetency data = new CoreCompetency("Data");

            Job test_job4 = new Job("Daryn", marine_corps, virginia, sre, data);
            Job test_job5 = new Job("Daryn", marine_corps, virginia, sre, data);

           Assert.IsFalse(test_job4.Equals(test_job5));

        }

        [TestMethod]
        public void TestFirstItemOfList()
        {
            Employer marine_corps = new Employer("Marine Corps");
            Location virginia = new Location("Virgina");
            PositionType sre = new PositionType("SRE");
            CoreCompetency data = new CoreCompetency("Data");

            Job test_job6 = new Job("Daryn", marine_corps, virginia, sre, data);

            string testString = test_job6.ToString();
            char firstChar = testString[0];
            char lastChar = testString[testString.Length - 1];

            Assert.IsTrue(firstChar == lastChar);
        }

        [TestMethod]
        public void TestToStringConstainsCorrectLabelsAndData()
        {

            Employer marine_corps = new Employer("Marine Corps");
            Location virginia = new Location("Virgina");
            PositionType sre = new PositionType("SRE");
            CoreCompetency data = new CoreCompetency("Data");

            Job test_job6 = new Job("Daryn", marine_corps, virginia, sre, data);

            string testOutput = $"\nID: {test_job6.JobId}\n Name: {test_job6.Name}\n Employer: {test_job6.EmployerName}\nLocation: {test_job6.EmployerLocation}\nPosition Type: {test_job6.JobType}\n Core Competency:{test_job6.JobCoreCompetency}\n";

            Assert.AreEqual(testOutput, test_job6.ToString());
        }
    }
}

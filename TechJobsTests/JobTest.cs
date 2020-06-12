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
            Assert.IsTrue(test_job3.JobCoreCompetency.value == "Persistence");

        }

        [TestMethod]
        public void TestJobsForEquality()
        {

        }

    }
}

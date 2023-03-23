
namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing Objects
        //initalize your testing objects here
        //Testing objects
        [TestMethod] //1
        public void TestSettingJobId()
        {
            // setup
            Job job1 = new Job();
            Job job2 = new Job();


            //verify
            Assert.AreNotEqual(job1, job2, " have same id number");
            Assert.AreEqual(1, job1.Id, "constructor not able to update Id");
            Assert.AreEqual(2, job2.Id, "Second constructor not able to update Id");

        }

        [TestMethod] //2
        public void TestJobConstructorSetsAllFields()
        {
            // setup
            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            //verify
            Assert.AreEqual("Product tester", job3.Name.ToString(), "Is Name set at time of declaration?");
            Assert.AreNotEqual("ACME", job3.EmployerName, "Is Employer Name set at time of declaration?");
            Assert.AreEqual("Desert", job3.EmployerLocation.ToString(), "Is Location set at time of declaration?");
            Assert.AreEqual("Quality control", job3.JobType.ToString(), "Is Job type set at time of declaration?");
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.ToString(), "Is Job Core set at time of declaration?");

        }

        [TestMethod] //3

        public void TestJobsForEquality()
        {
            // setup
            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            // verify
            Assert.AreNotEqual(job3, job4, "they are the same object");
        }

        [TestMethod]//4

        public void TestToStringStartsAndEndsWithNewLine()
        {
            //setup
            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual()
        }
    }
}


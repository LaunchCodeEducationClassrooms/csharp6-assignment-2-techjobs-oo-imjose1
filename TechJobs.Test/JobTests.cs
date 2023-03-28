
using System.Data;
using System.Xml.Linq;
using TechJobsOOAutoGraded6;

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
            Assert.IsFalse(job3.Equals(job4));
        }

        [TestMethod]//4

        public void TestToStringStartsAndEndsWithNewLine()
        {
            //setup
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
           

            //verify
            Assert.IsTrue(job1.ToString().StartsWith('\n'));
            Assert.IsTrue(job1.ToString().EndsWith('\n'));

            //Assert.AreEqual($"\n ID: {job1.Id} \n Name: {job1.Name} \n Employer: {job1.EmployerName} \n Location: {job1.EmployerLocation} \n Position Type: {job1.JobType} \n Core Competency: {job1.JobCoreCompetency} \n", job1.ToString());

        }

        [TestMethod]//5
        public void TestToStringContainsCorrectLabelsAndData()
        {
            //setup
            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            //verify
            Assert.AreEqual($"\n ID: {job3.Id} \n Name: {job3.Name} \n Employer: {job3.EmployerName} \n Location: {job3.EmployerLocation} \n Position Type: {job3.JobType} \n Core Competency: {job3.JobCoreCompetency} \n", job3.ToString(), "not correct id label and data");


        }

        [TestMethod] //6
        public void TestToStringHandlesEmptyField()
        {
            //setup
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            string output = $"\nID: {job3.Id}\nName: Ice cream tester\nEmployer: Data not available\nLocation: Home\nPosition Type: UX\nCore Competency: Tasting ability\n";

            // verify
            Assert.AreEqual(output, job3.ToString());
        }
    }
}

//        ID:  _______
//        Name: _______
//        Employer: _______
//        Location: _______
//        Position Type: _______
//        Core Competency: _______
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        //Declared job1, just saying the name. This work due to scoupe.
        Job job1;
        Job job2;
        Job job3;
        Job job4;
        Job job5;
        //object Id = null;
        //creates jobs object method.
        [TestInitialize]
        public void CreateJobObjects()
        {
            job1 = new Job();
            job2 = new Job();
            // this will need to go in the test.
            job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence")); 
            job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            job5 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType(""), new CoreCompetency("Tasting ability"));

        }


        [TestMethod]
        public void TestSettingJobId()
        {
// We are creating a new instance of the job class as job1

            // Job1 and job 2 need to be apart of the test of the creates jobs object method.
            // Set up empty job object and one that hass all of these things.
            //Job job1 = new Job();
            //Job job2 = new Job();
            //Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence")); // this will need to go in the test.
            Assert.AreNotSame(job1.Id, job2.Id);


        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {

            //Job job = new Job("Product tester", new Employer("ACME"),
            //    new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            // Checking to make sure values are properly assingned.
            Assert.IsTrue(job3.Name == "Product tester");
            Assert.AreSame(job3.EmployerName.Value, "ACME");
            Assert.AreSame(job3.EmployerLocation.Value, "Desert");
            Assert.AreSame(job3.JobType.Value, "Quality Control");
            Assert.AreSame(job3.JobCoreCompetency.ToString(), "Persistence");
            // would like to see about IsTrue method vs Aresame if you're using is true we are using it as a comparision.
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            // Compairing both jobs to check for diffrent uniqe IDs.
            
            // Checking to make sure values are properly assingned.
            Assert.IsFalse(job3.Equals(job4));

        }

        [TestMethod]
        public void TestToStringOutput()
        {
           //string acutual = job4.ToString();
           string expected = $"\r\nID: {job4.Id}\r\nName: {job4.Name}\r\nEmployer: {job4.EmployerName.Value}\r\n" +
                $"Location: {job4.EmployerLocation.Value}\r\nPosition: {job4.JobType.Value}\r\nCompetency: {job4.JobCoreCompetency.Value}\r\n";
            Assert.AreEqual(expected, job4.ToString());
        }

        [TestMethod]
        public void TestEmptySpots()
        {



            //string expected = $"\r\nID: 5\r\nName: Ice cream tester\r\nEmployer: Data not available\r\nLocation: Home"
            //    + "\r\nPosition: UX\r\nCompetency: Tasting ability\r\n";
            //Assert.AreEqual(expected, acutual);
            string acutual = job5.ToString();
            //job5.EmployerName.Value = "";
            //job5.JobType.Value = "";
            string expected = $"\r\nID: {job5.Id}\r\nName: {job5.Name}\r\nEmployer: Data not available\r\nLocation: {job5.EmployerLocation.Value}\r\nPosition: Data not available\r\nCompetency: {job5.JobCoreCompetency.Value}\r\n";
            Assert.AreEqual(expected, acutual);
        }
    }
   

}

// After test class anitialize for creat job objects this haapens before test setting ID

// "Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
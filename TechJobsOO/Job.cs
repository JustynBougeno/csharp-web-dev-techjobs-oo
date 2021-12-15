using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        //initialize the rest of the fields, while calling the initial constructor
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
              Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        // Returns job info itno a formatted string.
       
       
        public override string ToString()
        {
            string noData = "Data not available";
            string nullProofName = Name.Length > 0 ? Name : noData;
            string nullProofEmployer = EmployerName.Value.Length > 0 ? EmployerName.Value : noData;
            string nullProofEmployerLocation = EmployerLocation.Value.Length > 0 ? EmployerLocation.Value : noData;
            string nullProofJobType = JobType.Value.Length > 0 ? JobType.Value : noData;
            string nullProofJobCoreCompetency = JobCoreCompetency.ToString().Length > 0 ? JobCoreCompetency.ToString() : noData;

            // Setup conditional for ToString for empty values. On this line to say data no avaliabe for empty fields.
            string jobInfo =  $"\r\nID: {Id}\r\nName: {nullProofName}\r\nEmployer: {nullProofEmployer}\r\nLocation: {nullProofEmployerLocation}\r\n" +
                $"Position: {nullProofJobType}\r\nCompetency: {nullProofJobCoreCompetency}\r\n";

            return jobInfo;
        }
        // This below will go inside the ToString method.
        // TODO: Generate Equals() and GetHashCode() methods.
        
    }
}

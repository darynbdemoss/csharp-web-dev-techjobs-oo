using System;
namespace TechJobsOO
{
    public class Job
    {
        private static int jobId = 1;

        public int JobId { get; }
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.        
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {            
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public Job()
        {
            JobId = jobId;
            jobId++;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   JobId == job.JobId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(JobId);
        }

        

    }
}

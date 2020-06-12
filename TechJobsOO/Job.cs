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

        public override string ToString()
        {
            if(Name == null && EmployerName == null && EmployerLocation == null && JobType == null && JobCoreCompetency == null)
            {
                return "Ooo well";
            }

            if(Name == "")
            {
                Name = "Data Not available";
            }
            if(EmployerName.Value == "" || EmployerName.Value == null)
            {
                EmployerName.Value = "Data Not available";
            }
            if (EmployerLocation.Value == "" || EmployerLocation.Value == null)
            {
                EmployerLocation.Value = "Data Not available";
            }
            if (JobType.Value == "" || JobType.Value == null)
            {
                JobType.Value = "Data Not available";
            }
            if (JobCoreCompetency.Value == "" || JobCoreCompetency.Value == null)
            {
                JobCoreCompetency.Value = "Data Not available";
            }

            string output = $"\nID: {JobId}\n Name: {Name}\n Employer: {EmployerName}\nLocation: {EmployerLocation}\nPosition Type: {JobType}\n Core Competency:{JobCoreCompetency}\n";

            return output;
        }

    }
}

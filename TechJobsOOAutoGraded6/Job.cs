using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace TechJobsOOAutoGraded6
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

        // TODO: Task 3: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) :this ()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  
        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Task 5: Generate custom ToString() method.
        public override string ToString()
        {
          if(EmployerName.Value == "")
            {
                EmployerName.Value = "Data not available";

            }else if (EmployerLocation.Value == "")
            {
                EmployerLocation.Value = "Data not available";

            }else if (JobType.Value == "")
            {
                JobType.Value = "Data not available";
            }else if(JobCoreCompetency.Value == "")
            {
                JobCoreCompetency.Value = "Data not available";
            }
               
         //return Environment.NewLine+ $"ID: {Id}\nName: {Name}\nEmployer: {EmployerName}\nLocation: {EmployerLocation}\nPosition Type: {JobType}\nCore Competency: {JobCoreCompetency}"+ Environment.NewLine;
         return Environment.NewLine+"ID: "+Id+Environment.NewLine+"Name: "+Name+Environment.NewLine+"Employer: "+EmployerName+Environment.NewLine+"Location: "+EmployerLocation+Environment.NewLine+"Position Type: "+JobType+Environment.NewLine+"Core Competency: "+JobCoreCompetency+ Environment.NewLine;
              
        }
        //Until you create this method, you will not be able to print a job to the console.



    }
}

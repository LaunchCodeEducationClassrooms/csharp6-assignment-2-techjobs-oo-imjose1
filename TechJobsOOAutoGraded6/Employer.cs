using System;
namespace TechJobsOOAutoGraded6
{
	public class Employer :JobField
	{
        //public new int Id { get; }
        //private static int nextId = 1;
        //public new string Value { get; set; }


        public Employer(string value) : base(value)
        {
            Value = value;
        }
       
      
        //public abstract override bool Equals(object? obj);
        //public abstract override int GetHashCode();
        //public abstract override string ToString();
    }
}


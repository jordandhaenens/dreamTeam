using System;
using System.Collections.Generic;

namespace dreamTeam
{
    public interface ITeammate
    {
        string Specialty { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }
        void Work();
    }

    public class Matt : ITeammate
    {
        public string Specialty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName {
            get { return FirstName + " " + LastName;}
        }

        // Constructor
        public Matt (string spec, string first, string last)
        {
            this.Specialty = spec;
            this.FirstName = first;
            this.LastName = last;
        }
        public void Work()
        {
            Console.WriteLine($"la di da, I'm {FullName} and my speciality is {Specialty}");
        }
    }


     public class Eliza : ITeammate
    {
        public string Specialty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName {
            get { return FirstName + " " + LastName;}
        }

        // Constructor
        public Eliza (string spec, string first, string last)
        {
            this.Specialty = spec;
            this.FirstName = first;
            this.LastName = last;
        }
        public void Work()
        {
            Console.WriteLine($"la di da, I'm {FullName} and my speciality is {Specialty}");
        }
    }

    public class Andrew : ITeammate
    {
        public string Specialty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName {
            get { return FirstName + " " + LastName;}
        }

        // Constructor
        public Andrew (string spec, string first, string last)
        {
            this.Specialty = spec;
            this.FirstName = first;
            this.LastName = last;
        }
        public void Work()
        {
            Console.WriteLine($"la di da, I'm {FullName} and my speciality is {Specialty}");
        }
    }

    public class Chaz : ITeammate
    {
        public string Specialty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName {
            get { return FirstName + " " + LastName;}
        }

        // Constructor
        public Chaz (string spec, string first, string last)
        {
            this.Specialty = spec;
            this.FirstName = first;
            this.LastName = last;
        }
        public void Work()
        {
            Console.WriteLine($"la di da, I'm {FullName} and my speciality is {Specialty}");
        }
    }

    public class Tamela : ITeammate
    {
        public string Specialty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName {
            get { return FirstName + " " + LastName;}
        }

        // Constructor
        public Tamela (string spec, string first, string last)
        {
            this.Specialty = spec;
            this.FirstName = first;
            this.LastName = last;
        }
        public void Work()
        {
            Console.WriteLine($"la di da, I'm {FullName} and my speciality is {Specialty}");
        }
    }

    public class Jordan : ITeammate
    {
        public string Specialty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName {
            get { return FirstName + " " + LastName;}
        }

        // Constructor
        public Jordan (string spec, string first, string last)
        {
            this.Specialty = spec;
            this.FirstName = first;
            this.LastName = last;
        }
        public void Work()
        {
            Console.WriteLine($"la di da, I'm {FullName} and my speciality is {Specialty}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<ITeammate> serverSide = new List<ITeammate>(){
                new Matt ("sweaters", "Matt", "Augsberger"),
                new Eliza ("great convo", "Eliza", "Something"),
                new Andrew ("cheap beer", "Andrew", "Rock")
            };

            foreach (ITeammate person in serverSide) {
                person.Work();
            }

            List<ITeammate> clientSide = new List<ITeammate>(){
                new Jordan ("learning", "Jordan", "D"),
                new Chaz ("sharing info", "Chaz", "Something"),
                new Tamela ("making jokes", "Tamela", "Something")
            };

            foreach (ITeammate person in clientSide) {
                person.Work();
            }
             
        }
    }
}

// Specialty property - This holds the technology that the person enjoys the most.
// FirstName property
// LastName property
// FullName property - This property is a readonly property that returns the first and last name concatenated.
// Work() method - This will write a comical message to the console that describes the work they will do on a group project, based on their speciality.
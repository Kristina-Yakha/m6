using System;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace M6_CompositeExercise
{

    public class Bird : Taxonomy 
    {

        private string name;
        private string habitat;
        private bool nocturnal;
        private string location;
        private DateTime observationTime;

        public override string Name { get { return name; } }
        public string Location { get { return location; } }
        public override string Habitat { get { return habitat; } }
        public bool Nocturnal { get { return nocturnal; } }
        public DateTime ObservationTime { get { return observationTime; } }

        public Bird(string name, string habitat, bool nocturnal, string location, DateTime observationTime)
        {
            this.name = name;
            this.habitat = habitat;
            this.nocturnal = nocturnal;
            this.location = location;
            this.observationTime = observationTime;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}");
        }

        public override void Description()
        {

            string description = $"The {Name} lives in {Habitat} and ";

            if (nocturnal)
            {
                description += "is nocturnal. ";
            } else
            {
                description += "can be seen during the day. ";
            }

            description += $"The first time I saw the bird was on {observationTime.ToString("D",CultureInfo.CreateSpecificCulture("en-US"))} in {location}";
            
            Console.WriteLine(description);
        }

        

    }


}

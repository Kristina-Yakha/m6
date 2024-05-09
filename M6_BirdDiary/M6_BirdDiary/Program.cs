using System;

namespace M6_CompositeExercise
{

    class Program
    {

        public static void Main(string[] args)
        {
            Family birdObservationDiary = new Family("Birds", "Germany");
            Bird pidgeon = new Bird("Pidgeon", "Germany", false, "Berlin", new DateTime(2012,06,15));
            birdObservationDiary.Add(pidgeon);
            pidgeon.Description();
            //pidgeon.Print();
            Family birdsOfPrey = new Family("Birds of Prey", "Thuringia");

            birdObservationDiary.Add(birdsOfPrey);
           

            Bird milan = new Bird("Milan", "Thuringia", false, "Jena", new DateTime(2024, 05, 06));
            Bird kestrel = new Bird("Kestrel", "Thuringia", false, "Jena", new DateTime(2024, 03, 25));

            birdsOfPrey.Add(milan);
            birdsOfPrey.Add(kestrel);

            milan.Description();

            birdsOfPrey.Description();

            birdObservationDiary.Print();



        }
    }


}

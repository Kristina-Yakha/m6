using System;
using System.Runtime.CompilerServices;

namespace M6_CompositeExercise
{

    public class Family : Taxonomy
    {
        
        private List<Taxonomy> taxonomy = new List<Taxonomy>();
        private string name;
        private string habitat;

        public override string Name { get { return name; } }

        public override string Habitat { get { return habitat; } }



        public Family(string name, string habitat)
        {
            this.name = name;
            this.habitat = habitat;
        }
        


        public override void Print()
        {
            
            Console.WriteLine($"{Name}");


            foreach (Taxonomy node in taxonomy) {
                node.Print();

            }
        }

        public override void Description()
        {
            Console.WriteLine($"{Name} in {Habitat}.");
        }


        public void Add(Taxonomy node)
        {
            taxonomy.Add(node);
        }

        public void Remove(Taxonomy node)
        {
            taxonomy.Remove(node);
        }

        public Taxonomy GetEntry(int index)
        {
            return taxonomy[index];
        }



    }


}

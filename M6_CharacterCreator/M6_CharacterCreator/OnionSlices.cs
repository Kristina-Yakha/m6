using System;

namespace M6_Kitchen
{

    public class OnionSlices : IPrepareIngredient
    {

        private int numberOfSlices;

        public int NumberOfSlices { get; set; }
        
        public void PrepareVegetable(int numberOfSlices) { 
        
            Console.WriteLine($"The Onion has been cut into {numberOfSlices} slices");
            PeelVegetable();
            WashVegetable();
         }

        private void WashVegetable()
        {
            Console.WriteLine($"The Onion has been washed");
        }

        private void PeelVegetable()
        {
            Console.WriteLine($"The Onion has been peeled");
        }

    }
}

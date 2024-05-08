using System;

namespace M6_Kitchen
{

    public class OnePot
    {
        private static OnePot onePot = new OnePot();
        private List<Vegetable> ingredientsInPot;

        private OnePot()
        {
            Console.WriteLine("The pot has been placed on the stove.");
            this.ingredientsInPot = new List<Vegetable>();
        }

        public void AddVegetable (Vegetable vegetable, int slices)
        {
            ingredientsInPot.Add(vegetable);
            vegetable.PrepareVegetable(slices);
            Console.WriteLine($"A {vegetable.Name} has been added into the stew.");
        }
        public static OnePot GetPot()
        {
            return onePot;
        }
    }
}

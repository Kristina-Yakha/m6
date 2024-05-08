using System;

namespace M6_Kitchen
{
    class Program
    {
        static void Main(string[] args)
        {
            OnePot vegetableStew = OnePot.GetPot();

            Vegetable onionSlices = new Onion(new OnionSlices(), "Sliced Onion");

            vegetableStew.AddVegetable(onionSlices,3);

        }
    }
}
using System;

namespace M6_Kitchen
{

    public class Onion : Vegetable
    {
        
        private string name;

        public string Name { get { return name; } }


        public Onion(IPrepareIngredient prepareIngredient, string name) : base(prepareIngredient)
        {
            
            this.name  = name;
        }

        public override void PrepareVegetable(int slices)
        {
            prepareIngredient.PrepareVegetable(slices);
        }

     
  
  



}
}

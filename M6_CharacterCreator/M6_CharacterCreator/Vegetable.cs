using System;

namespace M6_Kitchen
{

    public abstract class Vegetable
    {
        protected IPrepareIngredient prepareIngredient;

        private string name;

        public string Name { get { return name; } }


        public Vegetable (IPrepareIngredient prepareIngredient, string name)
        {
            this.prepareIngredient = prepareIngredient;
            this.name = name;
        }

        public abstract void PrepareVegetable(int slices);
      

    }
}

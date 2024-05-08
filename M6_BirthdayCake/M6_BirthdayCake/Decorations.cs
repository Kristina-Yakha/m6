using System;

namespace DecoratorExercise
{
    public abstract class Decorations : ICake
    {

        protected ICake cake;

        public string Name { get; }
        public string Flavour { get; }

      

        public Decorations(ICake cake)
        {
          this.cake = cake;
        }

        public abstract string GetDescription();
        public abstract string EatCake();

     }



}

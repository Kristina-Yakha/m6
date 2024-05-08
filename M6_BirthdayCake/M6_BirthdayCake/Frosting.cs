using System;

namespace DecoratorExercise
{
    public 
        class CakeWithFrosting : Decorations
    {

        private ICake cake;
        private string name;
        private string flavour;
        private string frosting;

        public string Name { get { return name; } }
        public string Flavour { get { return flavour; } }

        public string Frosting { get { return frosting; } }

        public CakeWithFrosting(ICake cake, string frosting) : base(cake)
        {
            this.cake = cake;
            this.frosting = frosting;
        }

      
        public override string GetDescription()
        {
            return $"{ cake.GetDescription()} It is coated with a thick layer of {Frosting}-frosting.";
            
            
        }
        public override string EatCake()
        {
           
            return $"{cake.EatCake()} The frosting tastes like {Frosting}";
            
        }
         
     }



}

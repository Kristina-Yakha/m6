using System;

namespace DecoratorExercise
{
    public class Cake : ICake
    {

        private string name;
        private string flavour;
        public string Name { get { return name; } }
        public string Flavour { get { return flavour; } }
        
        
        public Cake(string name, string flavour)
        {
            this.name = name;
            this.flavour = flavour;
        }
        
        public string GetDescription()
        {
            return $"A simple {Name} that tastes like {Flavour}.";
        }
        public string EatCake()
        {
            return $"You have eaten the {Flavour}-flavoured {Name}.";
        }

    }



}

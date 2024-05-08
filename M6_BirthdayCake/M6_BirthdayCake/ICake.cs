using System;

namespace DecoratorExercise
{
    public interface ICake
    {
        string Name { get; }
        string Flavour { get; }
        
        string GetDescription();
        string EatCake();

    }



}

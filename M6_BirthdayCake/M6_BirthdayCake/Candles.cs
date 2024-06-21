using System;

namespace DecoratorExercise
{
    public 
        class CakeWithCandles : Decorations
    {

        private ICake cake;
        private string name;
        private string flavour;
        private int numberOfCandles;
        public bool candlesBurning;

        public string Name { get { return name; } }
        public string Flavour { get { return flavour; } }

        public int NumberOfCandles { get { return numberOfCandles+1; } }

        public CakeWithCandles(ICake cake, int numberOfCandles) : base(cake)
        {
            this.cake = cake;
            this.numberOfCandles = numberOfCandles;
            candlesBurning = true;
        }

      
        public override string GetDescription()
        {
            
            

            if (candlesBurning) return $"{cake.GetDescription()} On top are {numberOfCandles} burning candles.";
            else return $"{cake.GetDescription()} The {numberOfCandles} Candles on top are not burning.";

        }
        
        public void BlowOutCandles()
        {
            candlesBurning = false;
            Console.WriteLine("You blow out the candles."); 

        }
        
        public override string EatCake()
        {         
            if (candlesBurning) return $"You burn your tongue. Better blow out your candles first";
            else return cake.EatCake();
   
        }
         
     }



}

using System;

namespace M6_BakingTemplate
{

    public abstract class BakingInstruction
    {
               
        public void Bake()
        {
            PrepareFood();
            PutInOven();
            SetTimer();
            GetOut();
        }

        
        public void GetOut()
        {
            Console.WriteLine("You take the food out of the oven.");
        }
        public abstract void PrepareFood();

        public void PutInOven()
        {
            Console.WriteLine("You put the food into the oven");
        }

        public abstract void SetTimer();
       





    }
}

using System;

namespace M6_BakingTemplate
{

    public class Pizza : BakingInstruction
    {

        private int timer;
        private string name;

        public int Timer { get { return timer; }
            set { timer = value; } }
        public string Name { get { return name; } }

        public Pizza(string name, int timer = 20) { 
        
            this.timer = timer;
            this.name = name;
            
        }

                
        public override void PrepareFood()
        {
           Console.WriteLine($"You roll out the {Name} dough and put toppings on it.");
        }

        public override void SetTimer()
        {
            Console.WriteLine($"You set the timer to {timer} min.");
        }









    }
}

using System;

namespace M6_BakingTemplate
{

    public class Quiche : BakingInstruction
    {

        private int timer;
        private string name;

        public int Timer { get { return timer; }
            set { timer = value; } }
        public string Name { get { return name; } }

        public Quiche(string name, int timer = 30) { 
        
            this.timer = timer;
            this.name = name;
            
        }

                
        public override void PrepareFood()
        {
           Console.WriteLine($"For the {Name} you put the dough in cake tin and fill it with a mixture of eggs, cream, onions, cheese and bacon pieces.");
        }

        public override void SetTimer()
        {
            Console.WriteLine($"You set the timer to {timer} minutes.");
        }









    }
}

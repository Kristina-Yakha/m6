using System;

namespace M6_ItemGenerator
{

    public class Hammer : Item
    {
        private int attackValue;
        
        public int AttackValue
        {
            get
            {
                return attackValue;
            }
            set
            {
                attackValue = value;
            }
        }
       
        public Hammer(int attackValue) {
            Name = "Hammer";
            
            AttackValue = attackValue ;
        }
        
        public override void useItem()
        {
            Console.WriteLine($"You attack with your {Name} and make {AttackValue} damage.");

        }

    }


}
using System;

namespace M6_ItemGenerator
{

    public class Shield : Item
    {
        private int defenseValue;
        public int DefenseValue { 
            get
            {
                return defenseValue;
            }
            set
            {
                defenseValue = value;
            }
        }

        

       
        public Shield(int defenseValue) {
            Name = "Shield";
            DefenseValue = defenseValue;
            Random rnd = new Random();
        }
        public override void useItem()
        {
            Console.WriteLine($"You deflect {DefenseValue} damage with your {Name}.");
        }
        
    }


}


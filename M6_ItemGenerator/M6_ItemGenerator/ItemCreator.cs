using System;

namespace M6_ItemGenerator
{

    public class ItemCreator : Creator
    {

        protected override Item CreateRandomItem()
        {
            Item item = null;

            Random rnd = new Random();
            int itemNumber = rnd.Next(0,2);
            int itemValue = rnd.Next(1,10);

            switch(itemNumber)
            {
                case 0:
                    item = new Hammer(itemValue);
                    break;
                case 1:
                    item = new Shield(itemValue);
                    break;
                default:
                    Console.WriteLine("Item does not exist");
                    break;
            }

            

            return item;
        } 


    }


}


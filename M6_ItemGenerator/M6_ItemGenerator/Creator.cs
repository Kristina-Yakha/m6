using System;

namespace M6_ItemGenerator
{

    public abstract class Creator
    {
      
        protected abstract Item CreateRandomItem(); 

        public Item GenerateNewItem()
        {
            Item item = CreateRandomItem();

            item.useItem();
            //Console.WriteLine(item.Name);

            return item;
        }

    }


}


using System;

namespace M6_ItemGenerator
{

    public abstract class Item
    {
        //Properties
        public string Name { get; set; }
        public int ID { get; set; }

        //Methods

        public void GenerateItem()
        {
            Console.WriteLine("An Item has been created");

        }

        public abstract void useItem();

    }


}


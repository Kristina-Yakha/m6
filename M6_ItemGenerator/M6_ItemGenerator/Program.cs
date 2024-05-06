using System;

namespace M6_ItemGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator itemCreator = new ItemCreator();
            Item newItem = itemCreator.GenerateNewItem();
            
            
        }
    }

}

using System;

namespace M6_BakingTemplate
{

    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza("Pizza", 10);
            pizza.Bake();
            Quiche quiche = new Quiche("Quiche");
            quiche.Bake();

        }
    }
}

using Market.Classes;
using System;

namespace Market
{
    class StartUP
    {
        static void Main(string[] args)
        {
            Card bronzeCard = new BronzeCard("Gosho", 150m, 200m);
            Card silverCard = new SilverCard("Pesho", 400m, 700m);       
            Card goldenCard = new GoldenCard("Sasho", 1000m, 400m);


            PayDesk payDesk = new PayDesk();
            payDesk.AddToList(bronzeCard);
            payDesk.AddToList(silverCard);
            payDesk.AddToList(goldenCard);
            Console.WriteLine(payDesk.ToString());
        }
    }
}

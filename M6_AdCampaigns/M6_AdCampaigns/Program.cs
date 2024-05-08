using System;

namespace M6_AdCampaignStrategies
{
    class Program
    {
        public static void Main(string[] args)
        {
            Campaign gads = new Campaign(300, new DateTime(2024, 06, 01), new DateTime(2024, 12, 31), "Confetti");

            gads.SetNetwork(new GoogleAds());
            gads.Setup();
            gads.GetReport();

        }
    }

}
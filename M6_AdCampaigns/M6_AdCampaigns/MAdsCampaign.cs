using System;

namespace M6_AdCampaignStrategies
{
    public class MicrosoftAds : IAdsNetwork
    {
        private string name;

        public string Name { get { return name; } }

        public MicrosoftAds ()
        {
            this.name = "Microsoft Ads";

        }
        public void CreateCampaign(double budget, DateTime campaignStart, DateTime campaignEnd, string topic)
        {
            Console.WriteLine($"Campaign has been created: {Name}: Microsoft Search, Topic:{topic}, Runtime:{campaignStart:MM/dd/yyyy}-{campaignEnd:MM/dd/yyyy}, Budget:{budget}€");


        }

        public void CreateAd(string headline, string content, string url)
        {
            Console.WriteLine($"Headline 1:{headline}, Description Line 1: {content}, URL: {url}");

        }




    }








}
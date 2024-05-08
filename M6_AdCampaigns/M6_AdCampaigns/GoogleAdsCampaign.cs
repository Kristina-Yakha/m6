using System;

namespace M6_AdCampaignStrategies
{
    public class GoogleAds : IAdsNetwork
    {
        private string name;

        public string Name { get { return name; } }

        public GoogleAds() {
        this.name = "Google Ads";
        
        }

        public void CreateCampaign(double budget, DateTime campaignStart, DateTime campaignEnd, string topic)
        {
            Console.WriteLine($"Campaign has been created: {Name}: Search & Partner Network, Topic:{topic}, Runtime:{campaignStart:MM/dd/yyyy}-{campaignEnd:MM/dd/yyyy}, DailyBudget:{budget}€");


        }

        public void CreateAd(string headline, string content, string url)
        {
            Console.WriteLine($"Headline1:{headline}, Description: {content}, URL: {url}");

        }




    }








}
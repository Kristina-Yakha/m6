using System;

namespace M6_AdCampaignStrategies
{
    public class Facebook : IAdsNetwork
    {

        private string name;

        public string Name { get { return name; } }

        public Facebook()
        {
            this.name = "Facebook";

        }
        public void CreateCampaign(double budget, DateTime campaignStart, DateTime campaignEnd, string topic)
        {
            Console.WriteLine($"Campaign has been created:{Name}: Facebook and Intagram Feed, Topic:{topic}, Runtime:{campaignStart:MM/dd/yyyy}-{campaignEnd:MM/dd/yyyy}, Lifetime Budget:{budget}€.");


        }

        public void CreateAd(string headline, string content, string url)
        {
            Console.WriteLine($"Long Headline:{headline}, Body: {content}, URL: {url}");

        }




    }








}
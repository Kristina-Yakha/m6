using System;

namespace M6_AdCampaignStrategies
{
    public class Campaign
    {
        private double budget;
        private DateTime campaignStart;
        private DateTime campaignEnd;
        private IAdsNetwork network;
        private string topic;

        public Campaign(double budget, DateTime campaignStart, DateTime campaignEnd, string topic)
        {
            this.budget = budget;
            this.campaignStart = campaignStart;
            this.campaignEnd = campaignEnd;
            this.topic = topic;
        }

        public void SetNetwork(IAdsNetwork network)
        {
            this.network = network;
            Console.WriteLine("The ads network has been set to: " + network.Name);
        }


        public void Setup()
        {
            
                      
            network.CreateCampaign(budget, campaignStart, campaignEnd, topic);

            Console.WriteLine("Headline: ");
            string headline = Console.ReadLine();
            Console.WriteLine("Content: ");
            string content = Console.ReadLine();
            Console.WriteLine("URL: ");
            string url = Console.ReadLine();

            network.CreateAd(headline, content, url);


        }

        

        public void GetReport()
        {
            Console.WriteLine("A report has been generated.");
        }



    }

   



    


}
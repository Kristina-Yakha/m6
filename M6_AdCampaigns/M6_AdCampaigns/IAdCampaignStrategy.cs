using System;

namespace M6_AdCampaignStrategies
{
    public interface IAdsNetwork
    {
        public string Name { get;  }

    
        void CreateCampaign(double budget, DateTime campaignStart, DateTime campaignEnd, string topic);

        void CreateAd(string headline,string content, string url);

    

    }
}


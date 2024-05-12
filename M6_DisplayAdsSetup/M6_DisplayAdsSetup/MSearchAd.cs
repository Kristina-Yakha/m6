using System;

namespace M6_AbstractFactory_SearchAds
{

    public class MSearchAd : SearchAd
    {

        private string headline;
        private string content;
        private string url;


        public string Headline { get { return headline; }   }
        public string Content { get { return content; } }
        public string URL { get { return url; } }
        
        public MSearchAd(string headline, string content, string url) { 
        
        
            this.headline = headline;
            this.content = content;
            this.url = url;
        
        
        }
        
        public override void WriteText()
        {
            Console.WriteLine($"(Sponsored Ad)\n{Headline}!\n {Content}.\n {URL}");

        }

        
      




    }



}
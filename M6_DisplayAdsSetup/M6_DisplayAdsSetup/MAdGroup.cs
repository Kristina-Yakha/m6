using M6_AbstractFactory_SearchAds;
using System;
using System.Diagnostics.Tracing;

namespace M6_AbstractFactory_DisplayAds
{

    public class MAdGroup : AdGroups
    {
        public  List <Keywords> keywords;
        private string name;
        private SearchAd text;

        public override List<Keywords> Keywords { get; }
        public override string Name { get { return name; } }
        public override SearchAd Text { get { return text; } }   


        public MAdGroup(string name, SearchAd text, List<Keywords> keywords)
        {
            this.name = name;
            this.text= text;
            this.keywords = keywords;
        }

        public override string Upload()
        {
            return "The Ad Group has been successfully uploaded to MAds.";
        }




    }



}
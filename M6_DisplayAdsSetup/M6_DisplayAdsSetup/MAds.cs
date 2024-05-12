using M6_AbstractFactory_DisplayAds;
using System;

namespace M6_AbstractFactory_SearchAds
{

    public class MAds : SearchEngine
    {

        private List<AdGroups> setup;


        public override AdGroups CreateAdGroup(string name, MSearchAd text, List<Keywords> keywords )
        {
            return new MAdGroup(name, text, keywords);
        }

        public override CreateSetup()
        {
            setup.Add(MAdGroup);
        }




    }



}
using M6_AbstractFactory_SearchAds;
using System;
using System.Diagnostics.Tracing;

namespace M6_AbstractFactory_DisplayAds
{

    public abstract class AdGroups
    {

        public abstract List<Keywords> Keywords { get; }
   
        public abstract string Name { get; }
        public abstract SearchAd Text { get; }



        public abstract string Upload();




    }



}
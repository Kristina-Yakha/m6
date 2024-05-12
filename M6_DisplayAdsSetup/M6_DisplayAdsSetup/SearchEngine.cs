using M6_AbstractFactory_DisplayAds;
using System;

namespace M6_AbstractFactory_SearchAds
{

    public abstract class SearchEngine
    {

               
        public abstract AdGroups CreateAdGroups();

        public abstract SearchAd CreateSearchAd();
      




    }



}
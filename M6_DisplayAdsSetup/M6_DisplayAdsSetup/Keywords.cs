using System;

namespace M6_AbstractFactory_DisplayAds
{

    public class Keywords
    {

        List<string> keywordList;

        public Keywords()
        {
            keywordList = new List<string>();
        }

        public void AddKeyword(string keyword)
        {
            keywordList.Add(keyword);
        }



    }



}
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp1.Model
{
  public static  class DataServices
    {
        public static IList<Article> GetArticle()
        {
            return new List<Article>
            {
                new Article
                {
                    Title = "tv",
                    Author= "zee",
                    Articaleuser= "https://hyfytvapp.com/NkQLb6uUFt33NkJ1122VVv88GAX/HBO_HD/HBO_HD_800.m3u8"
                }
                ,
                 new Article
                {
                    Title = "google",
                    Author= "goolge",
                    Articaleuser= "http://google.com"
                }
            };
        }

    }
}

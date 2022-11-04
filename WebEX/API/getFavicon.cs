using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEX.API
{
    class getFavicon
    {
        public static void Get(string data)
        {
            int totalIcons = 0;
            try
            {
                var doc = new HtmlDocument();
                doc.LoadHtml(data);
                var authorsList = doc.DocumentNode.SelectNodes("//link[@href]");
                foreach (var node in authorsList)
                {
                    string content = node.GetAttributeValue("rel", "icon");
                    totalIcons++;
                }
                Console.WriteLine("Total Icons > " + totalIcons);
            }
            catch (Exception noData)
            {

            }
        }
    }
}

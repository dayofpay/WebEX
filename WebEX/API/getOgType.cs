using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEX.API
{
    class getOgType
    {
        public static void Get(string data)
        {
            try
            {
                var doc = new HtmlDocument();
                doc.LoadHtml(data);
                var authorsList = doc.DocumentNode.SelectNodes("//meta[@property='og:type']");
                foreach (var node in authorsList)
                {
                    string content = node.GetAttributeValue("content", "");
                    Console.WriteLine("Website Type > " + content);
                    Modules.Actions.CreateBlankLines(2);
                }
            }
            catch (Exception noData)
            {

            }
        }
    }
}

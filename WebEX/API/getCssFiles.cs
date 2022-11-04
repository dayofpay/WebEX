using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEX.API
{
    class getCssFiles
    {
        public static void Get(string data)
        {
            int cssFiles = 0;
            try
            {
                var doc = new HtmlDocument();
                doc.LoadHtml(data);
                var authorsList = doc.DocumentNode.SelectNodes("//link[@href]");
                foreach (var node in authorsList)
                {
                    string content = node.GetAttributeValue("rel", "stylesheet");
                    cssFiles++;
                }
                Console.WriteLine("Total CSS Files > " + cssFiles);
            }
            catch (Exception noData)
            {

            }
        }
    }
}

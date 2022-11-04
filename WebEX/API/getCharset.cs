using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEX.API
{
    class getCharset
    {
        public static void Get(string data)
        {
            try
            {
                var doc = new HtmlDocument();
                doc.LoadHtml(data);
                var authorsList = doc.DocumentNode.SelectNodes("//meta[@charset]");
                foreach (var node in authorsList)
                {
                    string content = node.GetAttributeValue("charset", "");
                    Console.WriteLine("Charset > " + content);
                }
            }
            catch (Exception noData)
            {

            }
        }
    }
}

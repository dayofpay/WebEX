﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEX.API
{
    class getOgTitle
    {
        public static void Get(string data)
        {
            try
            {
                var doc = new HtmlDocument();
                doc.LoadHtml(data);
                var authorsList = doc.DocumentNode.SelectNodes("//meta[@property='og:title']");
                foreach (var node in authorsList)
                {
                    string content = node.GetAttributeValue("content", "");
                    Console.WriteLine("OG:Title > " + content);
                }
            }
            catch (Exception noData)
            {

            }
        }
    }
}

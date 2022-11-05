using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebEX.API
{
    class resolveDomain
    {
        public static string getDomain
        {
            get;
            set;
        }
        public static string meta_authour_startpoint = "<meta name=\"author\" content=";
        public static string meta_authour_endPoint = "\">";
        public static void Lookup(string domain)
        {
            try
            {
                WebRequest request = WebRequest.Create(domain);
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                getAuthor.Get(responseFromServer);
                getCompany.Get(responseFromServer);
                getKeywords.Get(responseFromServer);
                getDescription.Get(responseFromServer);
                getRobots.Get(responseFromServer);
                getContentType.Get(responseFromServer);
                getLanguage.Get(responseFromServer);
                getOgTitle.Get(responseFromServer);
                getOgImage.Get(responseFromServer);
                getOgType.Get(responseFromServer);
                getOgDescription.Get(responseFromServer);
                Modules.Actions.CreateBlankLines(7);
                getFavicon.Get(responseFromServer);
                getCssFiles.Get(responseFromServer);
                getCharset.Get(responseFromServer);
                if (responseFromServer.Contains("bootstrap"))
                {
                    Modules.Actions.CreateBlankLines(2);
                    Modules.Actions.CreateInfo("[!] Found Bootstrap");
                    Modules.Actions.CreateBlankLines(2);
                }
                if (responseFromServer.Contains("https://www.googletagmanager.com/gtag/js"))
                {
                    Modules.Actions.CreateInfo("[!] Found Google Analytics");
                    Modules.Actions.CreateBlankLines(2);
                }
                if (!responseFromServer.Contains("<noscript>"))
                {
                    Modules.Actions.CreateInfo("[!] <noscript> tag not found, if you are the owner of the website we suggest you to use this tag !");
                    Modules.Actions.CreateBlankLines(2);
                }
                else if (responseFromServer.Contains("<noscript>"))
                {
                    Modules.Actions.CreateInfo("[!] NoScript Tag Found !");
                    Modules.Actions.CreateBlankLines(2);
                }
                Modules.Actions.CreateBlankLines(7);
                Console.WriteLine("[ DOMAIN DATA ]");
                Modules.Actions.CreateBlankLines(2);
                domainData.getDomainData(domain);
            }
            catch (Exception error)
            {
                Modules.Actions.CreateError("Error, please try again");
                if (Properties.Settings.Default.debugData == true)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }
    }
}

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebEX.API
{
    class domainData
    {
        public static void getDomainData(string domain)
        {
            string[] getPrefix = { "https://" };
            String[] getDomain = domain.Split(getPrefix, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                string apiCaller = "https://api.whoisfreaks.com/v1.0/whois?apiKey=" + API.ApiKey.key + "&whois=live&domainName=" + getDomain[0];
                WebRequest request = WebRequest.Create(apiCaller);
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                JObject jsReader = JObject.Parse(responseFromServer);
                string isValid = (string)jsReader?["domain_registered"];
                if (isValid == "yes")
                {
                    string createDate = (string)jsReader?["create_date"];
                    string expireDate = (string)jsReader?["expiry_date"];
                    string domainRegistrar_name = (string)jsReader?["domain_registrar"]["registrar_name"];
                    string domainRegistrar_whois_server = (string)jsReader?["domain_registrar"]["whois_server"];
                    string domainRegistrar_url = (string)jsReader?["domain_registrar"]["website_url"];
                    string domainRegistrar_email = (string)jsReader?["domain_registrar"]["email_address"];
                    string domainRegistrar_phone_num = (string)jsReader?["domain_registrar"]["phone_number"];
                    string registrant_contact = (string)jsReader?["registrant_contact"]["country_name"];
                    string admin_contact = (string)jsReader?["administrative_contact"]["email_address"];
                    string tech_contact = (string)jsReader?["technical_contact"]["email_address"];
                    string who_is_raw = (string)jsReader?["whois_raw_domain"];
                    Modules.Actions.CreateBlankLines(2);
                    Modules.Actions.CreateInfo($"Domain Create Date  - {createDate}");
                    Modules.Actions.CreateBlankLines(2);
                    Modules.Actions.CreateInfo($"Domain Expire  - {expireDate}");
                    Modules.Actions.CreateBlankLines(2);
                    Modules.Actions.CreateInfo($"Domain Registrar Name  - {domainRegistrar_name}");
                    Modules.Actions.CreateBlankLines(2);
                    Modules.Actions.CreateInfo($"Domain Registrar Server  - {domainRegistrar_whois_server}");
                    Modules.Actions.CreateBlankLines(2);
                    Modules.Actions.CreateInfo($"Domain Registrar URL  - {domainRegistrar_url}");
                    Modules.Actions.CreateBlankLines(2);
                    Modules.Actions.CreateInfo($"Domain Registrar E-Mail  - {domainRegistrar_email}");
                    Modules.Actions.CreateBlankLines(2);
                    Modules.Actions.CreateInfo($"Domain Registrar Phone Number  - {domainRegistrar_phone_num}");
                    Modules.Actions.CreateBlankLines(2);
                    Modules.Actions.CreateInfo($"Registrant Contact  - {registrant_contact}");
                    Modules.Actions.CreateBlankLines(2);
                    Modules.Actions.CreateInfo($"Admin E-Mail  - {admin_contact}");
                    Modules.Actions.CreateBlankLines(2);
                    Modules.Actions.CreateInfo($"Tech E-Mail  - {tech_contact}");
                    Modules.Actions.CreateBlankLines(2);
                    Modules.Actions.CreateBlankLines(2);
                    Modules.Actions.CreateInfo($"WHO IS  - {who_is_raw}");
                    Modules.Actions.CreateBlankLines(2);
                }
                else
                {
                    Console.WriteLine("not valid");
                }
            }
            catch (Exception error)
            {
                if (Properties.Settings.Default.debugData == true)
                { // NullReferenceException
                    Modules.Actions.CreateError($"Error while trying to parse data from domain {getDomain[0]}\r\nERROR:{error.Message}");
                }
            }
        }
    }
}

   
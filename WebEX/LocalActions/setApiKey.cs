using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEX.LocalActions
{
    class setApiKey
    {
        public static void Set(string newKey)
        {
            Properties.Settings.Default.apiKey = newKey;
            Properties.Settings.Default.Save();
            Console.WriteLine($"[{DateTime.Now.ToString()}] API-Key Changed !");
            Console.WriteLine($"[${DateTime.Now.ToString()}] NEW API-Key : {newKey}");
        }
    }
}

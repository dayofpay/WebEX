using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEX
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "WebEX | Coded by https://v-devs.online | dayofpay | V1.1";
            if (args.Length <= 0)
            {
                Operations.StartOperations.Operations.displayText();
            }
            else if(args[0] == "--resetSoftware")
            {
                Console.Clear();
            }
            else
            {
                if (LocalData.Commands.commands.Contains(args[0]))
                {
                    if(args[0] == LocalData.Commands.commands[0]) // Lookup
                    {
                        try
                        {
                            if(args[0] == "lookup" && args.Length == 3)
                            {
                                API.resolveDomain.Lookup(args[1],false);
                            }
                            else
                            {
                                API.resolveDomain.Lookup(args[1],true);
                            }
                        }catch(Exception error)
                        {

                        }
                    }
                }
            }
        }
    }
}



// V-DEVS BULGARIA 

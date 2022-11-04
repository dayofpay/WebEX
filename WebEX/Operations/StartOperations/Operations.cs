using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace WebEX.Operations.StartOperations
{
    class Operations
    {
        public static void displayText()
        {
            if(Properties.Settings.Default.startAnimation == true)
            {
                for (int i = 0; i <= 3; i++)
                {
                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (i == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (i == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.WriteLine(@"
░██╗░░░░░░░██╗███████╗██╗░░░░░░█████╗░░█████╗░███╗░░░███╗███████╗  ████████╗░█████╗░
░██║░░██╗░░██║██╔════╝██║░░░░░██╔══██╗██╔══██╗████╗░████║██╔════╝  ╚══██╔══╝██╔══██╗
░╚██╗████╗██╔╝█████╗░░██║░░░░░██║░░╚═╝██║░░██║██╔████╔██║█████╗░░  ░░░██║░░░██║░░██║
░░████╔═████║░██╔══╝░░██║░░░░░██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░  ░░░██║░░░██║░░██║
░░╚██╔╝░╚██╔╝░███████╗███████╗╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗  ░░░██║░░░╚█████╔╝
░░░╚═╝░░░╚═╝░░╚══════╝╚══════╝░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝  ░░░╚═╝░░░░╚════╝░

░██╗░░░░░░░██╗███████╗██████╗░███████╗██╗░░██╗  ░░███╗░░░░░░█████╗░
░██║░░██╗░░██║██╔════╝██╔══██╗██╔════╝╚██╗██╔╝  ░████║░░░░░██╔══██╗
░╚██╗████╗██╔╝█████╗░░██████╦╝█████╗░░░╚███╔╝░  ██╔██║░░░░░██║░░██║
░░████╔═████║░██╔══╝░░██╔══██╗██╔══╝░░░██╔██╗░  ╚═╝██║░░░░░██║░░██║
░░╚██╔╝░╚██╔╝░███████╗██████╦╝███████╗██╔╝╚██╗  ███████╗██╗╚█████╔╝
░░░╚═╝░░░╚═╝░░╚══════╝╚═════╝░╚══════╝╚═╝░░╚═╝  ╚══════╝╚═╝░╚════╝░");
                    Thread.Sleep(1250);
                    Console.Clear();
                }
            }
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                var getCommand = Console.ReadLine();
                var cmd = getCommand.Split(' ');
                if (LocalData.Commands.commands.Contains(cmd[0]))
                {
                    if (cmd[0] == "exit()")
                    {
                        break;
                    }
                    else if (cmd[0] == "reset()")
                    {
                        Program.Main(new string[] { "--resetSoftware" });
                    }
                    else if(cmd[0] == "lookup")
                    {
                        API.resolveDomain.Lookup(cmd[1]);
                    }
                    else if(cmd[0] == "setApi")
                    {
                        LocalActions.setApiKey.Set(cmd[1]);
                    }
                    else if(cmd[0] == "setProperty")
                    {
                        if (LocalData.Commands.args.Contains(cmd[1])){
                            if (cmd[1] == "debugData")
                            {
                                if (cmd[2] == "--disable")
                                {
                                    Properties.Settings.Default.debugData = false;
                                    Properties.Settings.Default.Save();
                                    Modules.Actions.CreateInfo("Succesfully disabled debug data");
                                }
                                else if (cmd[2] == "--enable")
                                {
                                    Properties.Settings.Default.debugData = true;
                                    Properties.Settings.Default.Save();
                                    Modules.Actions.CreateInfo("Succesfully enabled debug data");
                                }
                            }
                            else if(cmd[1] == "startAnimation")
                            {
                                if (cmd[2] == "--disable")
                                {
                                    Properties.Settings.Default.startAnimation = false;
                                    Properties.Settings.Default.Save();
                                    Modules.Actions.CreateInfo("Succesfully disabled Startup animations");
                                }
                                else if (cmd[2] == "--enable")
                                {
                                    Properties.Settings.Default.startAnimation = true;
                                    Properties.Settings.Default.Save();
                                    Modules.Actions.CreateInfo("Succesfully enabled Startup animations");
                                }
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Modules.Actions.CreateError("Invalid Argument !");
                        }
                    }
                }
                else
                {
                    Modules.Actions.CreateError("Invalid Command !");
                }
            }
        }
    }
}

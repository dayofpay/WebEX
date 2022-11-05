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
            if (Properties.Settings.Default.startAnimation == true)
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

░██╗░░░░░░░██╗███████╗██████╗░███████╗██╗░░██╗  ░░███╗░░░░░░░███╗░░
░██║░░██╗░░██║██╔════╝██╔══██╗██╔════╝╚██╗██╔╝  ░████║░░░░░░████║░░
░╚██╗████╗██╔╝█████╗░░██████╦╝█████╗░░░╚███╔╝░  ██╔██║░░░░░██╔██║░░
░░████╔═████║░██╔══╝░░██╔══██╗██╔══╝░░░██╔██╗░  ╚═╝██║░░░░░╚═╝██║░░
░░╚██╔╝░╚██╔╝░███████╗██████╦╝███████╗██╔╝╚██╗  ███████╗██╗███████╗
░░░╚═╝░░░╚═╝░░╚══════╝╚═════╝░╚══════╝╚═╝░░╚═╝  ╚══════╝╚═╝╚══════╝");
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
                    if (cmd[0] == "showCommands()")
                    {
                        foreach (string command in LocalData.Commands.commands)
                        {
                            Modules.Actions.CreateInfo("Command : " + command);
                        }
                    }
                    else if (cmd[0] == "cls()")
                    {
                        Modules.Actions.ClearConsole();
                    }
                    else if (cmd[0] == "exit()")
                    {
                        break;
                    }
                    else if (cmd[0] == "reset()")
                    {
                        Program.Main(new string[] { "--resetSoftware" });
                    }
                    else if (cmd[0] == "lookup")
                    {
                        try
                        {
                            API.resolveDomain.Lookup(cmd[1]);
                        }
                        catch (Exception noCommandInput)
                        {
                            Modules.Actions.CreateError($"There was an error while trying to execute command {cmd[0]}, please try again\r\n ERROR: ${noCommandInput.Message}");
                        }
                    }
                    else if (cmd[0] == "setApi")
                    {
                        try
                        {
                            LocalActions.setApiKey.Set(cmd[1]);
                        }
                        catch (Exception noApiKey)
                        {
                            Modules.Actions.CreateError("Please, insert valid API Key");
                        }
                    }
                    else if (cmd[0] == "setProperty")
                    {
                        try
                        {
                            if (LocalData.Commands.args.Contains(cmd[1]))
                            {
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
                                else if (cmd[1] == "startAnimation")
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
                        catch (Exception invalidProperty)
                        {
                            Modules.Actions.CreateError("Invalid Property Name !\r\nList Of All Property Names:");
                            foreach (string property in LocalData.Commands.args)
                            {
                                Modules.Actions.CreateInfo("Property : " + property);
                            }
                        }
                    }
                }
                else
                {
                    Modules.Actions.CreateError("Invalid Command !\r\nType showCommands() to see avaliable commands:");
                }
            }
        }
    }
}

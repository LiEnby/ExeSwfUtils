using ExeSwfFile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExeSwfECli
{
    internal class Program
    {
        static int ShowUsage()
        {
            Console.WriteLine("Usage: ");
            Console.WriteLine("\t -e / --extract <input exe> <output swf>");
            Console.WriteLine("\t -p / --projector-extract <input projector exe> <raw projector exe>");
            Console.WriteLine("\t -c / --create <input projector exe> <input swf> <output exe>");
            return -1;
        }
        static int Main(string[] args)
        {
            //args = new string[] { "-c", "tamagotch\\flash.exe", "tamagotch\\menu.swf", "tamagotch\\menu.exe" };

            if(args.Length >= 1)
            {
                string type = args[0];

                if (type.Equals("-e", StringComparison.InvariantCultureIgnoreCase) || type.Equals("--extract", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (args.Length < 3) return ShowUsage();
                    string input = args[1];
                    string output = args[2];
                    SwfExeExtractor.ExtractSwf(input, output);
                }
                else if (type.Equals("-p", StringComparison.InvariantCultureIgnoreCase) || type.Equals("--projector-extract", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (args.Length < 3) return ShowUsage();
                    string input = args[1];
                    string output = args[2];
                    SwfExeExtractor.ExtractRawProjector(input, output);
                }
                else if (type.Equals("-c", StringComparison.InvariantCultureIgnoreCase) || type.Equals("--create", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (args.Length < 4) return ShowUsage();
                    string inputProjector = args[1];
                    string inputSwf = args[2];
                    string output = args[3];
                    SwfExeCreator.CreateExe(inputProjector, inputSwf, output);
                }
                else
                {
                    return ShowUsage();
                }
            }
            else
            {
                return ShowUsage();
            }
            return 0;
        }
    }
}

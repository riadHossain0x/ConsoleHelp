using System;
using System.IO;

namespace ConsoleHelp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string funct = args[0].ToLowerInvariant();
                string file = args[1].ToLowerInvariant();
                if (File.Exists(file))
                {
                    switch (funct)
                    {
                        case "-p":
                            break;
                        case "-s":
                            break;
                        case "-w":
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("{Program Name} command-line, Nov 2019\n{Author Name}\n\n");

                int cursorPos = Console.CursorTop;
                Console.SetCursorPosition(0, cursorPos);

                for (int i = 0; i < commandText.Length; i++)
                {
                    Console.Write(commandText[i]);
                    Console.SetCursorPosition(30, i + cursorPos);
                    Console.WriteLine(helpText[i]);
                    Console.SetCursorPosition(0, i + cursorPos + 1);
                }
            }
        }

        static string[] commandText =
         {"-p <file> [<amount>]",
          "-s <file> <signature> ",
          "-w <file> <text>"};

        static string[] helpText = 
            {"{[i] Information About Command.}",
             "{[ii] Information About Command.}",
             "{[iii] Information About Command.}"}; 
    }
}

using System;
// Language: C#
// (un)Licensed by the Unlicense, for more information, please refer to <https://unlicense.org>

class Program
{
    static void Usage()
    {
        Console.WriteLine("usage: [--test | -t > Description for the argument]");
        Console.WriteLine("       [--help | -h > e.g. Outputs usage and exits.]");
    }

    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            // If no argument was given
            Console.WriteLine("no arguments were given");
            return;
        }

        foreach (var arg in args)
        {
            if (arg == "--test" || arg == "-t")
            {
                // If the `--test` or `-t` argument gets parsed
                Console.WriteLine("test parsed");
            }
            else if (arg == "--help" || arg == "-h")
            {
                Usage();
                return;
            }
            else
            {
                // If the argument parsed isn't in the list above
                Console.WriteLine($"unknown option: {arg}");
                Usage();
                return;
            }
        }
    }
}

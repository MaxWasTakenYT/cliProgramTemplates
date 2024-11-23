using System;
// Language: C#
// (un)Licensed by the Unlicense, for more information, please refer to <https://unlicense.org>

class Program
{
    static void Usage()
    {
        Console.WriteLine("Program usage:");
        Console.WriteLine("[--test | -t > Description for the argument]");
        Console.WriteLine("[--help | -h > e.g. Outputs usage and exits.]");
    }

    static void Main(string[] args)
    {
        if (args.Length == 0) {
            // If no argument was given
            Console.WriteLine("no arguments were given");
            return 1; // Optionally returns a non-zero value, which can be used to signal that an error occurred
        }

        foreach (var arg in args) {
            if (arg == "--test" || arg == "-t") {
                // If the `--test` or `-t` argument gets parsed, this will run
                Console.WriteLine("test parsed");
            }

            else if (arg == "--help" || arg == "-h") {
                Usage(); // Calls the `usage` function, outputting the usage message
                return 0;
            }

            else {
                // If the argument parsed isn't in the list above
                Console.WriteLine($"unknown option: {arg}");
                Usage();
                return 1; // Optionally returns a non-zero value, which can be used to signal that an error occurred
            }
        }
    }
}

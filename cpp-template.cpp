#include <iostream>
#include <string>
// Language: C++
// (un)Licensed by the Unlicense, for more information, please refer to <https://unlicense.org>

void usage() {
    std::cout << "Program usage:\n"
    << "[--test | -t > Description for the argument]\n"
    << "[--help | -h > e.g. Outputs usage and exits.]\n";
}

int main(int argc, char* argv[]) {
    if (argc == 1) {
        // If no argument was given
        std::cout << "no arguments were given\n";
        return 1; // Optionally returns a non-zero value, which can be used to signal that an error occurred
    }

    for (int i = 1; i < argc; ++i) {
        std::string arg = argv[i];

        if (arg == "--test" || arg == "-t") {
            // If the `--test` or `-t` argument gets parsed, this will run
            std::cout << "test parsed\n";
        }

        else if (arg == "--help" || arg == "-h") {
            usage(); // Calls the `usage` function, outputting the usage message
            return 0;
        }

        else {
            // If the argument parsed isn't in the list above
            std::cout << "unknown option: " << arg << "\n";
            usage();
            return 1; // Optionally returns a non-zero value, which can be used to signal that an error occurred
        }
    }
    return 0;
}


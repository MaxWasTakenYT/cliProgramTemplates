import sys
# Language: Python
# (un)Licensed by the Unlicense, for more information, please refer to <https://unlicense.org>

def usage():
    print("usage: [--test | -t > Description for the argument]")
    print("       [--help | -h > e.g. Outputs usage and exits.]")

def main():
    if len(sys.argv) == 1:
        # If no argument was given
        print("no arguments were given")
        return

    for arg in sys.argv[1:]:
        if arg in ["--test", "-t"]:
            # If the `--test` or `-t` argument gets parsed
            print("test parsed")
        elif arg in ["--help", "-h"]:
            usage()
            return
        else:
            # If the argument parsed isn't in the list above
            print(f"unknown option: {arg}")
            usage()
            return

if __name__ == "__main__":
    main()

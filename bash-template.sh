#!/bin/bash
# Language: Bash
# (un)Licensed by the Unlicense, for more information, please refer to <https://unlicense.org>

usage() {
    echo -e "usage: $0 \n[--test | -t > Description for the argument]\n [--help | -h > e.g. Outputs usage and exits.]\n"
}

if [[ "$#" -eq 0 ]]; then
    # If no argument was given, this will run
    echo -e "no arguments were given"
fi

while [[ "$#" -gt 0 ]]; do
    case "$1" in
        --test|-t) # If the `--test` or `-t` argument gets parsed, this will run
            echo -e "test parsed"
            shift
            ;;
        --help|-h)
          usage
          shift
          ;;
        # Other cases here, (just copy the examples' syntax)

        *) # This goes at the very end, (After all of your arguments)

            # If the argument parsed isn't in the list above, this will run
            echo -e "unknown option: $1"
            usage
            ;;
        esac # Closes the case
done # Ends the loop

// Language: Java
// (un)Licensed by the Unlicense, for more information, please refer to <https://unlicense.org>

public class Main {
    static void usage() {
        System.out.println("Program usage:");
        System.out.println("[--test | -t > Description for the argument]");
        System.out.println("[--help | -h > e.g. Outputs usage and exits.]");
    }

    public static void main(String[] args) {
        if (args.length == 0) {
            // If no argument was given
            System.out.println("no arguments were given");
            return 1; // Optionally returns a non-zero value, which can be used to signal that an error occurred
        }

        for (String arg : args) {
            switch (arg) {
                case "--test":
                case "-t":
                    // If the `--test` or `-t` argument gets parsed
                    System.out.println("test parsed");
                    break;
                case "--help":
                case "-h":
                    usage();
                    return 0;
                default:
                    // If the argument parsed isn't in the list above
                    System.out.println("unknown option: " + arg);
                    usage();
                    return 1; // Optionally returns a non-zero value, which can be used to signal that an error occurred
            }
        }
    }
}

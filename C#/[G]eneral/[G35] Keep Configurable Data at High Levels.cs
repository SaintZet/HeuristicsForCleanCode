public static void Main(String[] args)
{
    Arguments arguments = ParseCommandLine(args);
    ...
}
public class Arguments
{
    public static const string DEFAULT_PATH = ".";
    public static const string DEFAULT_ROOT = "FitNesseRoot";
    public static const int DEFAULT_PORT = 80;
    public static const int DEFAULT_VERSION_DAYS = 14;
        ...
}
// The command-line arguments are parsed in the very first executable line.
// The default values of those arguments are specified at the top of the Argument class.
// You don’t have to go looking in low levels of the system for statements like this one:

if (arguments.port == 0) // use 80 by default

//The configuration constants reside at a very high level and are easy to change.
//They get passed down to the rest of the application.
//The lower levels of the application do not own the values of these constants.

using File;
using Menu;
using settings_handle;

public class MainScript
{
    private CSVFile currentFile;
    private Settings settings;

    public static int Main()
    {
        Console.Beep();
        Console.WriteLine("TurboCSV 0.0.1");
        Console.WriteLine("Type 'help' for more information. ");

        MenuHandler.RunMenu();    

        return 0;
    }
}
using FileUtils;
using Menu;
using settings_handle;

public class MainScript
{
    private static CSVFile currentFile;
    private Settings settings;

    public static int Main()
    {
        Console.Beep();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("TurboCSV 0.0.1");
        Console.ResetColor();
        Console.WriteLine("Type 'help' for more information. ");

        MenuHandler.RunMenu();

        return 0;
    }

    public static string getCurrentFilePath()
    {
        return currentFile.currentPath;
    }

    public static void setCurrentFile(string path)
    {
        currentFile.currentPath = path;
    }

}
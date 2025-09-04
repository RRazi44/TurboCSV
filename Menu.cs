using settings_handle;
using Defines;

namespace Menu
{
    using static EXIT_CODE;

    public static class MenuHandler
    {
        private static Settings param;
        private static String USAGE = "turbocsv <csv>";

        //-------------------------------------|CONSTRUCTOR|-------------------------------------

        static MenuHandler()
        {
            Option[] options = new Option[1]; //definition de la liste d'options

            Dictionary<string, string> generalDict = new Dictionary<string, string>(); //definition de la map pour l'option "General"

            generalDict.Add("Verbosity", "True"); //Ajout de petites options au dictionnaire de general

            Option general = new Option("General", generalDict); //création de l'objet Option "general"
            param = new Settings(options); //Definition du settings final
        }

        public static EXIT_CODE RunMenu()
        {
            bool run = true;
            string answer = "";
            while (run)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write(">>> ");
                Console.ResetColor();

                // équivalent  à if(answer == null) answer = "";
                answer = Console.ReadLine() ?? "";

                string[] anwserList = answer.Split(" ");

                switch (anwserList[0])
                {
                    case "test":
                        Console.WriteLine("test");
                        break;
                    default:
                        Console.WriteLine(getUsage());
                        break;
                }

            }

            return EXIT_CODE.SUCCESSFUL;
        }

        public static String getHelp()
        {
            return "TODO";
        }

        public static String getUsage()
        {
            return USAGE;
        }

    }
}
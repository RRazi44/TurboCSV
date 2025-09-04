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
                Console.Write(">>> ");
                // équivalent  à if(answer == null) answer = "";
                answer = Console.ReadLine() ?? "";

                string[] anwserList = answer.Split(" ");

                if (!anwserList[0].ToLower().Equals("turbocsv"))
                {
                    Console.WriteLine(getUsage());
                    return EXIT_CODE.ERROR;
                }

                switch (anwserList[1])
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
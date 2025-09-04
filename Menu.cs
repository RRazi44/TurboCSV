using settings_handle;
using Defines;

namespace Menu
{
    using static EXIT_CODE;

    public static class MenuHandler
    {
        private static Settings param;

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
                Console.Write(">>>");
                Console.ResetColor();
                Console.Write(" ");

                // équivalent  à if(answer == null) answer = "";
                answer = Console.ReadLine() ?? "";
                string[] anwserList = RemoveSpace(answer);

                foreach (String arg in anwserList)
                {
                    Console.WriteLine(arg);
                }

                switch (anwserList[0])
                {
                    case "test":
                        Console.WriteLine("test");
                        break;
                    case "exit":
                        return EXIT_CODE.SUCCESSFUL;
                    default:
                        Console.WriteLine("");
                        break;
                }

            }

            return EXIT_CODE.SUCCESSFUL;
        }

        public static String getHelp()
        {
            return "TODO";
        }

        public static string[] RemoveSpace(string answer)
        {
            string[] answerList = answer.Split(' ');

            List<string> cleanList = new List<string>();
            foreach (string answerElt in answerList)
            {
                bool onlySpace = true;
                foreach (char letter in answerElt)
                {
                    if (letter != ' ')
                    {
                        onlySpace = false;
                        break;
                    }
                }
                if (!onlySpace)
                {
                    cleanList.Add(answerElt);
                }
            }

            return cleanList.ToArray();
        }


    }
}
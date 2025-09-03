using settings_handle;
using Defines;
using System.ComponentModel;

namespace Menu
{
    using static EXIT_CODE;
    public static class Menu
    {
        private static Settings param;

        //-------------------------------------|CONSTRUCTOR|-------------------------------------

        static Menu()
        {
            Option[] options = new Option[1]; //definition de la liste d'options

            Dictionary<string, string> generalDict = new Dictionary<string, string>(); //definition de la map pour l'option "General"

            generalDict.Add("Verbosity", "True"); //Ajout de petites options au dictionnaire de general

            Option general = new Option("General", generalDict); //création de l'objet Option "general"
            param = new Settings(options); //Definition du settings final
        }

        static EXIT_CODE RunMenu()
        {
            bool run = true;

            while (run)
            {
                string answer = "";

                switch (answer)
                {
                    default:
                    return SUCCESSFUL;
                }
            }

            return SUCCESSFUL;
        }
    }
}
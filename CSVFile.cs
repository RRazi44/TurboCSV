using Defines;
using static Defines.FILE_READING_CODE;
using System;
using System.IO;
using System.IO.Enumeration;
using System.IO.Pipelines;

namespace FileUtils
{
    public class CSVFile
    {
        public string currentPath = "ChineseGuys.csv";
        public FILE_READING_CODE lastState = SLEEP;

        /*-------------------------------------|CONSTRUCTOR|-------------------------------------*/
        public CSVFile(string path = "default")
        {
            if (path == "default")
            {
                currentPath = "ChineseGuys.csv";
                lastState = SLEEP;
            }
            else if (File.Exists(path))
            {
                currentPath = path;
                lastState = SLEEP;
            }
            else
            {
                lastState = UNRECOGNIZED;
            }
        }


        /*-------------------------------------|EXTRACTION|-------------------------------------*/
        public string ExtractAll() => File.ReadAllText(currentPath);

        /*-------------------------------------|GET|-------------------------------------*/

        public bool SetCurrentPath(string path)
        {
            if (File.Exists(path))
            {
                currentPath = path;
                lastState = SLEEP;
                return true;
            }

            lastState = UNRECOGNIZED;
            return false;
        }


        /*-------------------------------------|SET|-------------------------------------*/

        public string GetCurrentPath() => currentPath;

        /*-------------------------------------|INSERT|-------------------------------------*/

        public bool InsertEndLine(string lineFormat)
        {
            try
            {
                using StreamWriter write = new StreamWriter(currentPath);

                write.WriteLine(lineFormat);
            }
            catch (FileLoadException e)
            {
                Console.WriteLine($"ERROR : {e}");
                lastState = UNRECOGNIZED;
                return false;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"ERROR : {e}");
                lastState = UNRECOGNIZED;
                return false;
            }

            return true;
        }

        public bool InsertNLine(int n, string lineFormat)
        {
            return true;
        }
    }
}
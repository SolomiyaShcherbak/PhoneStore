using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore
{
    public class Logger
    {
        private static Logger instance = new Logger();
        private int lastError = 1;
        string fileName = "C:/Users/Private/source/repos/PhoneStore/PhoneStore/errors.txt";

        private Logger() { }

        public static Logger Instance()
        {
            return instance;
        }

        public void LogError(string error)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(lastError++ + ": " + error);
            }
        }
    }
}

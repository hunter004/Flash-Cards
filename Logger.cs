using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Flash_Cards
{
    class Logger
    {
        private string logLocation;

        public Logger(string logLocation)
        {
            this.logLocation = logLocation;
        }

        public void CreateNew()
        {
            //if the log exists, delete current log
            if (File.Exists(logLocation))
            {
                File.Delete(logLocation);
            }
        }

        public string location()
        {
            //return logLocation location in folder structure
            return logLocation;
        }

        public void Log(string lines)
        {
            //write to the log based on whatever string input is given
            System.IO.StreamWriter file = new System.IO.StreamWriter(logLocation, true);
            file.WriteLine(lines);
            file.Close();
        }
    }
}

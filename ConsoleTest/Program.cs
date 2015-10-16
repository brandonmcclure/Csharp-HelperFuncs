using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperFuncs;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger myLogger = new Logger();
            Logger.WriteToLog("Testing");

            myLogger.AddFilePath("\\Metadata.csv", "MetaData");
            myLogger.EnumerateAcceptableFilePaths();

            Console.ReadLine();
            return;
        }
    }
}

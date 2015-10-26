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
            string conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\\\pulse\\DavWWWRoot\\ehs\\epicprogram\\ProgramDocuments\\Cogito Build Tracker.xlsm; Extended Properties=Excel 12.0;";
            string query = "SELECT * FROM [Records$]";
            OleDBDataAccess data = new OleDBDataAccess( conn, query);
            Console.ReadLine();
            return;
        }
    }
}

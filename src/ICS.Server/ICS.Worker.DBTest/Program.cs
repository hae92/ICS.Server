using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ICS.Core.DBUtil;
using ICS.Core.Common;
using ICS.Core.DBUtil.Common;
using ICS.Core.DBUtil.Module;
using ICS.Core.DBUtil.Interface;

namespace ICS.Worker.DBTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DBInitial();

            var db = Singleton<DBUtil>.Instance.GetDatabase("OracleDB");

            DBTest01(db);
            DBTest02(db);
        }

        private static void DBInitial()
        {
            Singleton<DBUtil>.Instance.AddDatabase(
                "OracleDB",
                "192.168.60.247",
                "1625",
                "icsmgr ",
                "icsmgr ");

            //Singleton<DBUtil>.Instance.GetDatabase("OracleDB").Connect();
        }

        private static void DBTest01(ICommandDB db)
        {
            db.Connect();
            var query = "SELECT * FROM TAB";
            Console.WriteLine(db.SelectQuery(query).ConvertToCsv(true));
            db.Close();
        }

        private static void DBTest02(ICommandDB db)
        {
            db.Connect();
            var query = "SELECT * FROM TEST";
            Console.WriteLine(db.SelectQuery(query).ConvertToCsv(true));
            db.Close();
        }
    }
}

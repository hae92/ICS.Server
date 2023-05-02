using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICS.Core.DBUtil.Common
{
    public class TableParseExtension
    {
        public static string ColumnToString(object _)
        {
            return _.ToString();
        }

        public static int ColumnToInt32(object _)
        {
            Int32.TryParse(_.ToString(), out Int32 i);
            return i;
        }

        public static long ColumnToInt64(object _)
        {
            Int64.TryParse(_.ToString(), out Int64 l);
            return l;
        }

        public static bool ColumnToBoolen(object _, string condition)
        {
            Boolean b = false;
            b = (_.ToString() == condition) ? true : false;
            return b;
        }

        public static DateTime ColumnToDataTime(object _, string expression)
        {
            DateTime dt = default(DateTime);
            dt = DateTime.ParseExact(_.ToString().Trim(), expression, null);
            return dt;
        }

    }
}

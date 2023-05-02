using ICS.Core.DBUtil.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICS.Core.DBUtil.Interface
{
    public interface ICommandDB
    {
        void Init(string str);
        ConnectionState GetConnectionState();
        void Connect();
        void Close();
        Boolean NonSelectQuery(string sql);
        DBData SelectQuery(string sql);
    }
}

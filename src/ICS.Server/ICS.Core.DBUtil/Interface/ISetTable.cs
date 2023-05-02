
using System.Data;


namespace ICS.Core.DBUtil.Interface
{
    public interface ISetTable { T[] SetTable<T>(DataTable dr); }
}

using System.Data;
using Elevate.ElevateDB.Data;

namespace Edb.Extensions
{
    public class EdbDataTableCommand : EDBCommand, IEdbCommand<DataTable>
    {
        public EdbDataTableCommand(string command, EDBConnection connection) : base(command, connection)
        {
        }

        public new DataTable Execute()
        {
            DataTable dt = new DataTable();
            dt.Load(ExecuteReader());
            return dt;
        }
    }
}

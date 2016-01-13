using Elevate.ElevateDB.Data;

namespace Edb.Extensions
{
    public class EdbAffectedRowsCommand : EDBCommand, IEdbCommand<int>
    {
        public EdbAffectedRowsCommand(string command, EDBConnection connection) : base(command, connection)
        {
        }
    }
}

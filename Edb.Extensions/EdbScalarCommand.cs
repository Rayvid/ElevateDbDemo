using Elevate.ElevateDB.Data;

namespace Edb.Extensions
{
    public class EdbScalarCommand<TResult> : EDBCommand, IEdbCommand<TResult>
    {
        public EdbScalarCommand(string command, EDBConnection connection) : base(command, connection)
        {
        }

        public new TResult Execute()
        {
            return (TResult) ExecuteScalar();
        }
    }
}

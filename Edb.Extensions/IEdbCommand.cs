namespace Edb.Extensions
{
    public interface IEdbCommand<TResult>
    {
        TResult Execute();
    }
}

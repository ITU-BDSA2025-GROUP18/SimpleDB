// See https://aka.ms/new-console-template for more information

namespace SimpleDB;

public sealed class CSVDatabase<T> : IDatabaseRepository<T>
{
    public IEnumerable<T> Read(int? limit = null)
    {
        return null;
    }

    public void Store(T record)
    {
    }
}
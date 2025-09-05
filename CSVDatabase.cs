using System.Globalization;
using CsvHelper;

namespace SimpleDB;

sealed class CSVDatabase<T> : IDatabaseRepository<T> //Sealed modifier prevents subclasses
{
    public IEnumerable<T> Read(int limit) //For at gøre den generic (Fremgået også på billedet
    {
        using var reader = new StreamReader("chirp_cli_db.csv");
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        return csv.GetRecords<T>().ToList(); //<Cheep> --> <T> for at gøre den generic
    }
    
    public void Store(T message) //For at gøre den generic (Fremgår også på billedet)
    {
        var author = Environment.UserName;
        var utcTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        var record = new Cheep(author, message, utcTimestamp);

        using var writer = new StreamWriter("chirp_cli_db.csv", append: true);
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.WriteRecord(record);
        writer.WriteLine();
    }
}
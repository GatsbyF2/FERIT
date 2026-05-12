using System.Collections.ObjectModel;

public interface IDataset
{
    ReadOnlyCollection<List<string>> GetData();
}

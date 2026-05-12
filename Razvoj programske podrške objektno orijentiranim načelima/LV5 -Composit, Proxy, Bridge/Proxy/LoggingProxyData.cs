using System.Collections.ObjectModel;

public class LoggingProxyData : IDataset
{
    Dataset dataset;
    ConsoleLogger logger;


    public LoggingProxyData(string filePath)
    {
        dataset = new Dataset(filePath);
        logger = ConsoleLogger.GetInstance();
    }

    public ReadOnlyCollection<List<string>> GetData()
    {
        logger.Log("Loading Data...");
        var data = dataset.GetData();
        logger.Log("Data loaded succesfully!");
        return data;
    }



}
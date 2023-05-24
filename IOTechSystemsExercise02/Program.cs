using System.Buffers.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using IOTechSystemsExercise02.Models;
using IOTechSystemsExercise02.Utility;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    private readonly IJsonHandler _deviceDataProvider;
    private readonly IValueCalculator _valueCalculator;
    private readonly IInfoParser _infoParser;
    private readonly IJsonFileHandler _resultWriter;

    public Program(IJsonHandler deviceDataProvider, IValueCalculator valueCalculator, IInfoParser infoParser, IJsonFileHandler resultWriter)
    {
        _deviceDataProvider = deviceDataProvider;
        _valueCalculator = valueCalculator;
        _infoParser = infoParser;
        _resultWriter = resultWriter;
    }

    private void Run()
    {
        List<IDeviceDTO> devices = _deviceDataProvider.GetDevices();

        IResultDTO resultDTO = new ResultDTO()
        {
            ValueTotal = _valueCalculator.SumValues(devices),
            UUIDS = _infoParser.GetUUIDS(devices)
        };

        _resultWriter.WriteJsonToFile(resultDTO);
    }

    private static void Main(string[] args)
    {
        IJsonHandler deviceDataProvider = new JsonHandler();
        IValueCalculator valueCalculator = new ValueCalculator();
        IInfoParser infoParser = new InfoParser();
        IJsonFileHandler resultWriter = new JsonFileHandler();

        Program program = new Program(deviceDataProvider, valueCalculator, infoParser, resultWriter);
        program.Run();
    }
}
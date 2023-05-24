using IOTechSystemsExercise02.Models;

namespace IOTechSystemsExercise02.Utility
{
    public interface IJsonHandler
    {
        string JsonPath { get; set; }

        List<IDeviceDTO> GetDevices();
    }
}
using IOTechSystemsExercise02.Models;

namespace IOTechSystemsExercise02.Utility
{
    public interface IInfoParser
    {
        string[] GetUUIDS(List<IDeviceDTO> devices);
    }
}
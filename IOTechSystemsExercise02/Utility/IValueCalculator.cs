using IOTechSystemsExercise02.Models;

namespace IOTechSystemsExercise02.Utility
{
    public interface IValueCalculator
    {
        int SumValues(List<IDeviceDTO> devices);
    }
}
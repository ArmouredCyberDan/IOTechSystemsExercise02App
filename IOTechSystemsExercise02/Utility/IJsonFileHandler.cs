using IOTechSystemsExercise02.Models;

namespace IOTechSystemsExercise02.Utility
{
    public interface IJsonFileHandler
    {
        void WriteJsonToFile(IResultDTO resultToWrite);
    }
}
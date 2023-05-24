namespace IOTechSystemsExercise02.Models
{
    public interface IDeviceDTO
    {
        string Info { get; set; }
        string Name { get; set; }
        DateTime TimeStamp { get; set; }
        string Type { get; set; }
        string Value { get; set; }

        DateTime CalculateTimeStamp(string timeStamp);
    }
}
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTechSystemsExercise02.Models
{
    public class DeviceDTO : IDeviceDTO
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Info { get; set; }
        public string Value { get; set; }
        public DateTime TimeStamp { get; set; }

        public DeviceDTO(string name, string type, string info, string value, string timeStamp)
        {
            Name = name;
            Type = type;
            Info = info;
            Value = DecodeBase64Value(value);
            TimeStamp = CalculateTimeStamp(timeStamp);
        }


        public string DecodeBase64Value(string value)
        {
            var output = System.Convert.FromBase64String(value);
            return System.Text.Encoding.UTF8.GetString(output);
        }

        public DateTime CalculateTimeStamp(string timeStamp)
        {
            DateTime output = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            output = output.AddSeconds(double.Parse(timeStamp)).ToLocalTime();
            return output;
        }

    }
}

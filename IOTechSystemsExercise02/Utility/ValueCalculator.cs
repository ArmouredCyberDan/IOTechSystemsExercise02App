using IOTechSystemsExercise02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTechSystemsExercise02.Utility
{
    public class ValueCalculator : IValueCalculator
    {
        public int SumValues(List<IDeviceDTO> devices)
        {
            int output = 0;

            foreach (var device in devices)
            {
                output += Int32.Parse(device.Value);
            }

            return output;
        }
    }
}

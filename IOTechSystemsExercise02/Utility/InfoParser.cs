using IOTechSystemsExercise02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IOTechSystemsExercise02.Utility
{
    public class InfoParser : IInfoParser
    {
        public string[] GetUUIDS(List<IDeviceDTO> devices)
        {
            string[] output = new string[devices.Count];

            try
            {
                for (int i = 0; i < devices.Count; i++)
                {
                    Match match = Regex.Match(devices[i].Info, @"uuid:(.*?),");
                    if (match.Success)
                    {
                        string uuid = match.Groups[1].Value;
                        output[i] = uuid;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Something went wrong when trying to get the UUIDs, please try again. For more information on this issue check the error message : {ex.ToString()}");

            }

            return output;
        }
    }
}

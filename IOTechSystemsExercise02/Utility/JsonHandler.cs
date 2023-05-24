using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using IOTechSystemsExercise02.Models;

namespace IOTechSystemsExercise02.Utility
{
    public class JsonHandler : IJsonHandler
    {
        public string JsonPath { get; set; }

        public JsonHandler()
        {
            JsonPath = "C:\\Users\\gwi\\source\\repos\\IOTechSystemsExercise02App\\IOTechSystemsExercise02\\data\\data.json";
        }

        public List<IDeviceDTO> GetDevices()
        {
            List<IDeviceDTO> output = new List<IDeviceDTO>();

            try
            {
                string jsonString = File.ReadAllText(JsonPath);
                var jsonNode = JsonNode.Parse(jsonString);

                

                foreach (var device in jsonNode["Devices"].AsArray())
                {
                    output.Add(
                        new DeviceDTO(
                            device["Name"].ToString(),
                            device["Type"].ToString(),
                            device["Info"].ToString(),
                            device["value"].ToString(),
                            device["timestamp"].ToString())
                        { });
                }

                output.RemoveAll(x => x.TimeStamp < DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong when trying to read the file, please try again. For more information on this issue, check the error message : {ex.ToString()}");
            }

            return output;
        }
    }
}

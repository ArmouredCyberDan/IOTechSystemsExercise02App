using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using IOTechSystemsExercise02.Models;
using IOTechSystemsExercise02.Utility;

namespace IOTechSystemsExercise02.Utility
{
    public class JsonFileHandler : IJsonFileHandler
    {
        public void WriteJsonToFile(IResultDTO resultToWrite)
        {
            try
            {
                var output = JsonSerializer.Serialize(resultToWrite);

                File.WriteAllText("output.json", output);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Something went wrong when trying to save the object to the file, please try again. For more information on this issue check the error message : {ex.ToString()}");
            }
           
        }
    }
}

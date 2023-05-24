using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTechSystemsExercise02.Models
{
    public class ResultDTO : IResultDTO
    {
        public int ValueTotal { get; set; }
        public string[] UUIDS { get; set; }
    }
}

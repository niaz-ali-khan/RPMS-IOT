using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Common
{
    public class Telemetry
    {

        public string Patient { get; set; }
        public string Device { get; set; }
        public int GlucoseFigure  { get; set; }
        public Level HealthLevel { get; set; }
        public DateTime RecordingTime { get; set; }
        public int Temperature { get; set; }
        public int HeartRate { get; set; }
    }
}

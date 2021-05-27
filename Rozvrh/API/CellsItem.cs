using System;
using System.Collections.Generic;
using System.Text;

namespace Rozvrh.API
{
    public class CellsItem
    {
        public string GroupName { get; set; }
        public string Subject { get; set; }
        public string Teacher { get; set; }
        public string ClassRoom { get; set; }
        public string MeetUrl { get; set; }
        public DateTime StartTime { get; set; }
    }
}

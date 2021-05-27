using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Rozvrh.API
{
    public static class TimeTableManager
    {
        private const string URL = "https://sis.ssakhk.cz/api/v1/getTimetableByUserId?";
        private static WebClient _client = new WebClient();

        public static TimeTableDay GetTimeTable(int userId, DateTime date)
        {
            StringBuilder builder = new StringBuilder(URL);
            builder.Append("userId=");
            builder.Append(userId);
            builder.Append("&datetime=");
            builder.Append(date.ToString("MM-dd-yyyy"));

            string data = _client.DownloadString(builder.ToString());
            return JsonConvert.DeserializeObject<TimeTableDay>(data);
        }
    }
}

using CommonLibrary;
using System;

namespace ComputeDateTimes
{
    public class DateTimeComputing : IExecutable
    {
        public string Execute(string value)
        {
            var dateTime = DateTime.Parse(value);
            return $@"{{
                ""utc"": ""{dateTime.ToUniversalTime()}"", 
                ""yyyymmdd"": ""{dateTime.ToString("yyyyMMdd")}"", 
                ""tiks"": {dateTime.Ticks}
            }}";
        }
    }
}

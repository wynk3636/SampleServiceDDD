using System;
namespace Sample.Common
{

    public class Constant
    {
        //japanese time zone info
        readonly TimeZoneInfo japanTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
        // eastern
        readonly TimeZoneInfo etTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
    }
}

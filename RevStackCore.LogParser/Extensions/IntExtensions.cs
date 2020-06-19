using System;
namespace RevStackCore.LogParser
{
    public static class IntExtensions
    {
        public static DateTimeOffset Quantize(this int timeInMilliseconds)
        {
            return DateTimeOffset.FromUnixTimeSeconds(timeInMilliseconds / 1000);
        }
    }
}

using System;
using System.Globalization;

namespace RevStackCore.LogParser
{
    public class TimeConvertor : ITextConvertor
    {
        //public dynamic Convert(string text) => DateTimeOffset.ParseExact(text, "HH':'mm':'ss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
        public dynamic Convert(string text) => DateTime.Parse(text);
    }
}

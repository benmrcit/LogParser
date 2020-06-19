using System;
using System.Globalization;

namespace RevStackCore.LogParser
{
    public class DateTimeOffsetConvertor : ITextConvertor
    {
        //public dynamic Convert(string text) => DateTimeOffset.ParseExact(text, "yyyy'-'MM'-'dd", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
        public dynamic Convert(string text) => DateTime.Parse(text);
    }
}

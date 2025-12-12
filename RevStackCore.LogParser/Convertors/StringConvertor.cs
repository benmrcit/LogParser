namespace RevStackCore.LogParser
{
    public class StringConvertor : ITextConvertor
    {
        public dynamic Convert(string text) => "-".Equals(text) ? null : text;
    }
}

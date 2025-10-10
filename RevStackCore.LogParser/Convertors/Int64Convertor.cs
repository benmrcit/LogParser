namespace RevStackCore.LogParser
{
    public class Int64Convertor : ITextConvertor
    {
        public dynamic Convert(string text) => System.Convert.ToInt64(text);
    }
}

namespace RevStackCore.LogParser
{
    public class Int32Convertor : ITextConvertor
    {
        public dynamic Convert(string text) => System.Convert.ToInt32(text);
    }
}

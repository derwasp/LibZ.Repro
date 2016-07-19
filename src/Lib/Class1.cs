namespace Lib
{
    public class Class1
    {
        public int Foo()
        {
            var client = new RestSharp.RestClient();
            return client.Encoding.ToString().Length;
        }
    }
}

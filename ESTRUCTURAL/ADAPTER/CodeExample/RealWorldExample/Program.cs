using System;
using Newtonsoft.Json;

namespace RealWorldExample
{
    /// <summary>
    /// Real world Adapter pattern Example
    /// You are consuming one third party API in your application. Currently, the API is sending the response in JSON format 
    /// </summary>
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Before Changes");
            var result = new ThirdParyApiOriginalApi().GetCustomer();
            Console.WriteLine(result.ToString());

            Console.ReadKey();

            Console.WriteLine("After changes");
            //For the example i rename the api to ThirdPartyv2 but in the real example the name was the same and te original code must create ThirdParyApiOriginalApi object
            var adapterResult = new XmlToJsonAdapter(new ThirdParyApiv2()).ConvertXmlToJson();
            Console.WriteLine(adapterResult.ToString());
        }
    }

    /// <summary>
    /// Create a interface IConvertor to convert the new xml response of v2 to Json format that the original response
    /// </summary>
    public interface IConvertor
    {
        string ConvertXmlToJson();
    }

    /// <summary>
    /// Create a class named XmlToJsonAdapter and Inject the dependency
    /// </summary>
    public class XmlToJsonAdapter : IConvertor
    {
        private readonly ThirdParyApiv2 _xmlConverter;

        public XmlToJsonAdapter(ThirdParyApiv2 xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }

        public string ConvertXmlToJson()
        {

            string jsonText = JsonConvert.SerializeXNode(ThirdParyApiv2.GetXML());
            return jsonText;
        }
    }

}

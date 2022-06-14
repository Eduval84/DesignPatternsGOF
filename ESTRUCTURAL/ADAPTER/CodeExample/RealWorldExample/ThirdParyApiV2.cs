using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace RealWorldExample
{
    /// <summary>
    /// The third party API,decided to change the response from JSON to XML.
    /// To use the new response format we need to use the Adapter pattern 
    /// </summary>
    public class ThirdParyApiv2
    {
        public static XDocument GetXML()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Customers");
            var customer = new Customer();
            var xAttributes = Customer.GetData()
                .Select(m => new XElement("Customer",
                    new XAttribute("City", m.City),
                    new XAttribute("Name", m.Name),
                    new XAttribute("Address", m.Address)));

            xElement.Add(xAttributes);
            xDocument.Add(xElement);
            return xDocument;
        }
    }
}
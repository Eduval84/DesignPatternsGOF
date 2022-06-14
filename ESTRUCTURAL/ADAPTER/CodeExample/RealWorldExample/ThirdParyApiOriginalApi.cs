using System.Collections.Generic;
using Newtonsoft.Json;

namespace RealWorldExample
{
    /// <summary>
    /// the original api 
    /// </summary>
    public class ThirdParyApiOriginalApi
    {
        private readonly Customer _customer = new Customer();
        public object GetCustomer() => JsonConvert.SerializeObject(Customer.GetData());
    }

   
}
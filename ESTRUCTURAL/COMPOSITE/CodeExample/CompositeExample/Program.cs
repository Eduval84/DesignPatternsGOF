using System;

namespace CompositeExample
{
    class Program
    {
        /// <summary>
        /// Composite pattern - Structural pattern
        /// 
        /// Purpose:
        /// (1) If there is tree kind of structure where leaf & composite nodes are present and both of want to be treated uniformally
        /// you can use composite pattern.
        /// 
        /// Scenario:
        /// (1) Customer(1)--->Address(1...*) ----> PhoneNos(1...*)
        /// 
        /// Explanation:
        /// All 3 classes are treated uniformally & there can be a INode interface which is implemented by all 3.
        /// </summary>
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Edu";

            Adress adress = new Adress();
            adress.Name = "Direccion 1";

            Adress adress2 = new Adress();
            adress2.Name = "Direccion 2";

            PhoneNos phoneNos = new PhoneNos();
            phoneNos.Name = "+34 888 11 22";

            PhoneNos phoneNos2 = new PhoneNos();
            phoneNos2.Name = "+34 888 33 44";

            PhoneNos phoneNos3 = new PhoneNos();
            phoneNos3.Name = "+34 888 44 55";

            customer.Add(adress);
            customer.Add(adress2);

            adress.Add(phoneNos);
            adress2.Add(phoneNos2);
            adress2.Add(phoneNos3);

            Console.WriteLine(customer.Name += ",");

            foreach (Adress ad in customer.connectNode)
            {
                Console.WriteLine("Adress: " + ad.Name + ",");
                foreach (PhoneNos phone in ad.connectedNode)
                {
                    Console.Write("Phone: " + phone.Name + Environment.NewLine);
                }
            }
        }
    }
}

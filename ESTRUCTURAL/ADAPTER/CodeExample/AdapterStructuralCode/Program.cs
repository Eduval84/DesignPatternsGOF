using System;

namespace AdapterStructuralCode
{
    internal class Program
    {
        /// <summary>
        /// Adapter Desing Pattern, ejemplo de estructura de código 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Codigo original heredado con dependencias
            Customer customer = new Customer();
            customer.FirstName();

            //Esperando por el usuario
            Console.ReadKey();

            //Creando el adaptador y añadiendole un método
            Customer customerAdapter = new Adapter();
            customerAdapter.FirstName();

        }
    }

    /// <summary>
    /// La clase cliente
    /// </summary>
    internal class Customer
    {
        public virtual void FirstName()
        {
            Console.WriteLine("Llamando al metodo FirstName de la clase Customer");
        }
    }

    internal class Adapter : Customer
    {
        private Adaptee adaptee = new Adaptee();

        public override void FirstName()
        {
            //Posibilidad de hacer otro trabajo y despues llamar al metodo especifico
            adaptee.SpecificFirstName();
        }
    }

    internal class Adaptee
    {
        public void SpecificFirstName()
        {
            Console.WriteLine("Llamando al metodo especifico ");
        }
    }
}

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
            //Codigo original o clase existente
            ExistingClass existingClass = new ExistingClass();
            existingClass.FirstName();

            //Esperando por el usuario
            Console.ReadKey();

            //Creando el adaptador y añadiendole un método
            ExistingClass existingClassAdapter = new Adapter();
            existingClassAdapter.FirstName();

        }
    }

    /// <summary>
    /// La clase cliente
    /// </summary>
    internal class ExistingClass
    {
        public virtual void FirstName()
        {
            Console.WriteLine("Llamando al metodo de la clase original");
        }
    }

    internal class Adapter : ExistingClass
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
            Console.WriteLine("Llamando al metodo especifico de la clase adaptada");
        }
    }
}

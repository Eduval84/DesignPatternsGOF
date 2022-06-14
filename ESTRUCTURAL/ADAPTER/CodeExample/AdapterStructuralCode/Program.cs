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
            //ExistingClass existingClass = new ExistingClass();
            //existingClass.ExistingMethod();

            //Creando el adaptador para poder tratarlo igual que el original
            ExistingClass existingClass = new Adapter();
            existingClass.ExistingMethod();

            //Esperando por el usuario
            Console.ReadKey();

        }
    }

    /// <summary>
    /// La clase cliente
    /// </summary>
    internal class ExistingClass
    {
        public virtual void ExistingMethod()
        {
            Console.WriteLine("Llamando al metodo de la clase original");
        }
    }

    internal class Adapter : ExistingClass
    {
        private Adaptee adaptee = new Adaptee();

        public override void ExistingMethod()
        {
            //Posibilidad de hacer otro trabajo y despues llamar al metodo especifico
            adaptee.SpecificExistingMethod();
        }
    }

    internal class Adaptee
    {
        public void SpecificExistingMethod()
        {
            Console.WriteLine("Llamando al metodo especifico de la clase adaptada");
        }
    }
}

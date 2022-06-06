using System;
using System.Threading.Tasks.Dataflow;
using Composite;

namespace Composite
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Composite.Client client = new Composite.Client();

            //De esta manera el clodigo del cliente puede soportar componentes simples de tipo hoja
            var hoja = new Hoja();
            Console.WriteLine("Cliente: Tengo un componente sencillo:");
            client.ClientCode(hoja);

            //Tambien puede soportar  los objetos compuestos complejos
            Composite arbol = new Composite();

            Composite rama1 = new Composite();
            rama1.Add(new Hoja());
            rama1.Add(new Hoja());

            Composite rama2 = new Composite();
            rama2.Add(new Hoja());

            arbol.Add(rama1);
            arbol.Add(rama2);
            Console.WriteLine("Cliente: Ahora tenemos un arbol compuesto");
            client.ClientCode(arbol);

            Console.WriteLine("Cliente: No necesito verificar las clases de componentes incluso cuando administro el árbol ");

        }
    }
}

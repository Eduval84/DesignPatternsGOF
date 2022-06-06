using System;
using System.Collections.Generic;

namespace Composite
{
    internal abstract class Component
    {
        //La clase base Component declara opreaciones comunes para objetos simples y complejos de una composicion
        public Component () { }

        //El componente base puede implementar algún comportamiento predeterminado o dejarlo a clases concretas (declarando el método que contiene el comportamiento como "abstracto")
        public abstract string Operation();

        // En algunos casos, sería beneficioso definir la gestión de los hijos de esta manera no haras opreaciones directametne en la clase de componente.
        // Se necesita exponer cualquier clase de componente concreto al código del cliente, incluso durante el ensamblaje del árbol de objetos. La desventaja es que estos métodos estarán vacíos para los componentes a nivel de hoja.
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        // Podemos proporcionar un método que permita que el código del cliente descubra si un componente puede tener hijos.
        public virtual bool IsComposite()
        {
            return true;
        }
    }

    internal class Hoja: Component
    {
        public override string Operation()
        {
            return "Hoja";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }

    // La clase Composite representa los componentes complejos que pueden tener hijos. Por lo general, los objetos compuestos delegan el trabajo real a sus hijos y luego "resumir" el resultado.
    internal class Composite : Component
    {
        protected List<Component> _Hijo = new List<Component>();

       
        public override void Add(Component component)
        {
            this._Hijo.Add(component);
        }

        public override void Remove(Component component)
        {
            this._Hijo.Remove(component);
        }

        // El Composite ejecuta su lógica primaria de una manera particular. Eso atraviesa recursivamente a través de todos sus hijos, recopilando y sumando sus resultados.
        // Dado que los hijos del compuesto llama a sus hijos y así sucesivamente, sucesivamente toodo el árbol de objetos se recorre como resultado 
        public override string Operation()
        {
           int cont = 0;
           string result = "Rama(";

           foreach (Component component in _Hijo)
           {
               result += component.Operation();
               if (cont != _Hijo.Count - 1)
               {
                   result += "+";
               }
           }
           return result + ")";

        }

        public class Client
        {
            //El cliente trabaja con todos los implicados gracias a la clase base interfaz (internal abstract class Component)
            public void ClientCode(Component hoja)
            {
                Console.WriteLine($"Resultado: {hoja.Operation()}\n");
            }
        }
    }
}

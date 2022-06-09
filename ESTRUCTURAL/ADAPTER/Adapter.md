# **ADAPTER**
## 📖Definicion

Permite la colaboracion entre objetos con interfaces incompatibles. Un adaptador envuelve uno de los objetos para esconder la complejidad de la conversión que tiene lugar de fondo. El objeto envuelto ni siquiera es consciente de la existencia del adaptador. 

Complejidad:

🟥⬛⬛

Popularidad:

💚💚💚

**Ejemplos de uso:** El patrón Composite es muy común en el código C#. Se utiliza a menudo en sistemas basados en algún codigo heredado. En estos casos, los adaptadores crean código heredado con clases modernas.

**Identificación:** Es reconocible por un constructor que toma una instancia de distindo tipo de clase abstracta/interfaz. Cuando el adaptador recibe una llamada a uno de sus métodos, convierte los parámetros al formato adecuado y despues dirige la llamada a uno o varios métodos del objeto envuelto.
* * * * *
## 💡 Aplicabilidad

*  **Utiliza la clase adaptadora cuando quieras usar  una clase existente, pero cuya ingerfaz no sea compatible con el resto del código**

   ⚡ *  El patrón adapter te permite crear una clase intermediaria que sirva como traductora entre tu código y una clase heredada, una clase de un tercero o cualqueir otra clase con una interfaz extraña.

* **Utila el patrón cuando quieras que el código cliente trate elementos simples y compejos de la misma forma**

   ⚡ *  Al compartir un interfaz común el cliente no tiene que preocuparse por la clase concreta de los objetos con los que funciona.
* * * * *
## Estructura

![](https://refactoring.guru/images/patterns/diagrams/composite/structure-es.png)

1. La interfaz **Component** describe el metodo *'excute()'*, que sera comun a elemntos simples y complejos del arbol.
2. La **hoja o leaf** es un elemento básico de un arbol que no tiene sub-elementos. Normalmente, los componentes de la hoja acaban realizando la mayoria del trabajo real, ya que no tienen a nadie a quien delegarle el trabajo.
3. El contenedor **composite o compuesto** es un elemento que tiene sub-elementos: hojas u otros contenedores. Un contenedor no conoce las clases concretas de sus hijos.Funciona con todos los sub-elementos únicamente a trave´s de la interfaz componente. Al recibir una solicitud, un contenedor  delega el traajo a sus sub-elementos, procesa los resultados yintermedios y devuelve el resultado final al cliente.
4. El **Cliente** funciona como todos los elementos a través de la interfaz component. Como resultado, el cliente puede fucnonar de la misma manera tanto con elementos simpñles como comjelos de árbol.


[Ejemplo del UML en c#](CodeExample\Composite\Component.cs)

[Ejemplo practico en c#](CodeExample\CompositeExample\INode.cs)

* * * * *
## ⚖ Pros y Contras

✔ Puedes trabajar con estructuras de árbol complejas con mayor comodidad: utiliza el polimorfismo y la recursión en tu favor.

✔ Principio de abierto/cerrado. Puedes introducir nuevos tipos de elemento en la aplicación sin descomponer el código existente, que ahora funciona con el árbol de objetos. 

❌ Puede resultar difícil proporcionar una interfaz común para clases cuya funcionalidad difiere demasiado. En algunos casos, tendrás que generalizar en exceso la interfaz componente, provocando que sea más difícil de comprender.
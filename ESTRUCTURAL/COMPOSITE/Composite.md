# **COMPOSITE**
## 📖Definicion

Permite componer objetos en estructuras de arbol para representar jerarquieas y trabajar como si fueran objetos individuales y composiciones de objetos de manera uniforme.

Complejidad:

🟥🟥⬛

Popularidad:

💚💚🖤

***
😟**Problema** 

El uso del patrón Composite sólo tiene sentido cuando el modelo central de tu aplicación puede representarse en forma de árbol.

Por ejemplo, imagina que tienes dos tipos de objetos: Productos y Cajas. Una Caja puede contener varios Productos así como cierto número de Cajas más pequeñas. Estas Cajas pequeñas también pueden contener algunos Productos o incluso Cajas más pequeñas, y así sucesivamente.

Digamos que decides crear un sistema de pedidos que utiliza estas clases. Los pedidos pueden contener productos sencillos sin envolver, así como cajas llenas de productos... y otras cajas. ¿Cómo determinarás el precio total de ese pedido?


![](https://refactoring.guru/images/patterns/diagrams/composite/problem-es.png)

Puedes intentar la solución directa: desenvolver todas las cajas, repasar todos los productos y calcular el total. Esto sería viable en el mundo real; pero en un programa no es tan fácil como ejecutar un bucle. Tienes que conocer de antemano las clases de Productos y Cajas a iterar, el nivel de anidación de las cajas y otros detalles desagradables. Todo esto provoca que la solución directa sea demasiado complicada, o incluso imposible.

😄**Solución** 

El patrón Composite sugiere que trabajes con Productos y Cajas a través de una interfaz común que declara un método para calcular el precio total.

¿Cómo funcionaría este método? Para un producto, sencillamente devuelve el precio del producto. Para una caja, recorre cada artículo que contiene la caja, pregunta su precio y devuelve un total por la caja. Si uno de esos artículos fuera una caja más pequeña, esa caja también comenzaría a repasar su contenido y así sucesivamente, hasta que se calcule el precio de todos los componentes internos. Una caja podría incluso añadir costos adicionales al precio final, como costos de empaquetado.

![](https://refactoring.guru/images/patterns/content/composite/composite-comic-1-es.png)

La gran ventaja de esta solución es que no tienes que preocuparte por las clases concretas de los objetos que componen el árbol. No tienes que saber si un objeto es un producto simple o una sofisticada caja. Puedes tratarlos a todos por igual a través de la interfaz común. Cuando invocas un método, los propios objetos pasan la solicitud a lo largo del árbol.

***

**Ejemplos de uso:** El patrón Composite es muy común en el código C#. Se utiliza a menudo para representar jerarquías de componentes de interfaz de usuario o el código que trabaja con gráficos.

**Identificación:** El Composite es fácil de reconocer por los métodos de comportamiento que toman una instancia del mismo tipo abstracto/interfaz y lo hacen una estructura de árbol.
* * * * *
## 💡 Aplicabilidad

*  **Usar el patron Composite cuando el modelo central de tu aplicación puede representarse en una estructura de objetos en forma de arbol.**

   ⚡ *  Este patrón te proporciona dos tipos de elementos basicos que comarten una interfaz común: hojas(leaf) simples y contenedores complejos. Un contenedor puede estar compuesto por hojas y por otros contenedores. Esto te permite construir una estructrua de objetos recursivos anidados.

* **Utiliza el patrón cuando quieras que el código cliente trate elementos simples y compejos de la misma forma**

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


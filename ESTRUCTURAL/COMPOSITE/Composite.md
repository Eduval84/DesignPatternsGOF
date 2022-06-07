# **COMPOSITE**
## 📖Definicion

Permite componer objetos en estructuras de arbol para representar jerarquieas y trabajar como si fueran objetos individuales y composiciones de objetos de manera uniforme.

Complejidad:

🟥🟥⬛

Popularidad:

💚💚🖤

**Ejemplos de uso:** El patrón Composite es muy común en el código C#. Se utiliza a menudo para representar jerarquías de componentes de interfaz de usuario o el código que trabaja con gráficos.

**Identificación:** El Composite es fácil de reconocer por los métodos de comportamiento que toman una instancia del mismo tipo abstracto/interfaz y lo hacen una estructura de árbol.
* * * * *
## 💡 Aplicabilidad

*  **Usar el patron Composite cuando el modelo central de tu aplicación puede representarse en una estructura de objetos en forma de arbol.**

   ⚡ *  Este patrón te proporciona dos tipos de elementos basicos que comarten una interfaz común: hojas(leaf) simples y contenedores complejos. Un contenedor puede estar compuesto por hojas y por otros contenedores. Esto te permite construir una estructrua de objetos recursivos anidados.

* **Utila el patrón cuando quieras que el código cliente trate elementos simples y compejos de la misma forma**

   ⚡ *  Al compartir un interfaz común el cliente no tiene que preocuparse por la clase concreta de los objetos con los que funciona.
* * * * *
## Estructura

![](https://refactoring.guru/images/patterns/diagrams/composite/structure-es.png)

1. La interfaz **Component** describe el metodo *'excute()'*, que sera comun a elemntos simples y complejos del arbol.
2. La **hoja o leaf** es un elemento básico de un arbol que no tiene sub-elementos. Normalmente, los componentes de la hoja acaban realizando la mayoria del trabajo real, ya que no tienen a nadie a quien delegarle el trabajo.
3. El contenedor **composite o compuesto** es un elemento que tiene sub-elementos: hojas u otros contenedores. Un contenedor no conoce las clases concretas de sus hijos.Funciona con todos los sub-elementos únicamente a trave´s de la interfaz componente. Al recibir una solicitud, un contenedor  delega el traajo a sus sub-elementos, procesa los resultados yintermedios y devuelve el resultado final al cliente.
4. El **Cliente** funciona como todos los elementos a través de la interfaz component. Como resultado, el cliente puede fucnonar de la misma manera tanto con elementos simpñles como comjelos de árbol.


[Ejemplo en c#](ESTRUCTURAL\COMPOSITE\CodeExample\Composite\Composite.sln)

* * * * *
## ⚖ Pros y Contras

✔ Puedes trabajar con estructuras de árbol complejas con mayor comodidad: utiliza el polimorfismo y la recursión en tu favor.

✔ Principio de abierto/cerrado. Puedes introducir nuevos tipos de elemento en la aplicación sin descomponer el código existente, que ahora funciona con el árbol de objetos. 

❌ Puede resultar difícil proporcionar una interfaz común para clases cuya funcionalidad difiere demasiado. En algunos casos, tendrás que generalizar en exceso la interfaz componente, provocando que sea más difícil de comprender.


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

* **Utila el patrón cuando quieras reutilizar varias subclases existentes que carezcan de alguna funcionalidad común que no pueda añadirse a la superclase.**

   ⚡ *  Puedes extender cada subclase y colocar la funcionalidad que falta, dentro de las nuevas clases hijas. No obstante, deberás suplicar el código en todas esas nuevas clases, lo cual **huele muy mal**. La solucion mas elegante es colocar la funcionalidad que falta dentro de una clase adaptadora, después puedes envolver obbjetos a los que les falten fucniones, dentro de la clase adaptadora, obteniendo esas funciones necesarias de un modo dinámico. Para que esto funcione deben tener una interfaz comun y el campo de la clase adaptadora debe seguir dicha interfaz. Este comportamiento es muy similar al del patrón **Decorator**.
* * * * *
## Estructura

### Adaptador de objetos

![](https://refactoring.guru/images/patterns/diagrams/adapter/structure-object-adapter.png)

1. La clase cliente contiene la logica de negocio existente del programa.
2. 

### Clase adaptadora

Esta implementación utiliza la herencia, porque la clase adaptadora hereda interfaces de ambos objetos al mismo tiempo. Ten en cuenta que esta opción sólo puede implementarse en lenguajes de programación que soporten la herencia múltiple, como C++.


![](https://refactoring.guru/images/patterns/diagrams/adapter/structure-class-adapter.png)

1. La **clase adaptadora** no necesita envolver objetos porque hereda comportamientos tando de la clase cliente como de la clase de servicio. La adaptacion tiene lugar dentro de los métodos dsobreescritos. La clase adaptadora resultante puede utilzarse en lugar de una clase cliente existente.
****

[Ejemplo del UML en c#](CodeExample\Composite\Component.cs)

[Ejemplo practico en c#](CodeExample\CompositeExample\INode.cs)

* * * * *
## ⚖ Pros y Contras

✔ Principio de responsabilidad única. Puedes separar la interfaz o el código de conversión de datos de la lógica de negocio primaria del programa.

✔ Principio de abierto/cerrado. Puedes introducir nuevos tipos de adaptadores al programa sin descomponer el código cliente existente, siempre y cuando trabajen con los adaptadores a través de la interfaz con el cliente. 

❌ La complejidad general del código aumenta, ya que debes introducir un grupo de nuevas interfaces y clases. En ocasiones resulta más sencillo cambiar la clase de servicio de modo que coincida con el resto de tu código.
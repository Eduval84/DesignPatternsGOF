# **ADAPTER**
## 馃摉Definicion

Permite la colaboracion entre objetos con interfaces incompatibles. Un adaptador envuelve uno de los objetos para esconder la complejidad de la conversi贸n que tiene lugar de fondo. El objeto envuelto ni siquiera es consciente de la existencia del adaptador. 

Complejidad:

馃煡猬涒瑳

Popularidad:

馃挌馃挌馃挌

**Ejemplos de uso:** El patr贸n Adapter es muy com煤n en el c贸digo C#. Se utiliza a menudo en sistemas basados en alg煤n codigo heredado. En estos casos, los adaptadores crean c贸digo heredado con clases modernas.

**Identificaci贸n:** Es reconocible por un constructor que toma una instancia de distindo tipo de clase abstracta/interfaz. Cuando el adaptador recibe una llamada a uno de sus m茅todos, convierte los par谩metros al formato adecuado y despues dirige la llamada a uno o varios m茅todos del objeto envuelto.
* * * * *
## 馃挕 Aplicabilidad

*  **Utiliza la clase adaptadora cuando quieras usar  una clase existente, pero cuya ingerfaz no sea compatible con el resto del c贸digo**

   鈿? *  El patr贸n adapter te permite crear una clase intermediaria que sirva como traductora entre tu c贸digo y una clase heredada, una clase de un tercero o cualqueir otra clase con una interfaz extra帽a.

* **Utila el patr贸n cuando quieras reutilizar varias subclases existentes que carezcan de alguna funcionalidad com煤n que no pueda a帽adirse a la superclase.**

   鈿? *  Puedes extender cada subclase y colocar la funcionalidad que falta, dentro de las nuevas clases hijas. No obstante, deber谩s suplicar el c贸digo en todas esas nuevas clases, lo cual **huele muy mal**. La solucion mas elegante es colocar la funcionalidad que falta dentro de una clase adaptadora, despu茅s puedes envolver obbjetos a los que les falten fucniones, dentro de la clase adaptadora, obteniendo esas funciones necesarias de un modo din谩mico. Para que esto funcione deben tener una interfaz comun y el campo de la clase adaptadora debe seguir dicha interfaz. Este comportamiento es muy similar al del patr贸n **Decorator**.
* * * * *
## Estructura

### Adaptador de objetos

![](https://refactoring.guru/images/patterns/diagrams/adapter/structure-object-adapter.png)

1. La clase cliente contiene la logica de negocio existente del programa.
2. La interfaz con el cliente describe un protoclo que otras clases deben seguir par poder colaborar con el c贸digo cliente.
3. Servicio es alguna clase 煤til (normalmente de una tercera parte o heredada). El cliente no puede utilizar directamete esta clase porque tiene una interfaz incompatible.
4. La clase adaptadora es capaz de trabajar tanto con la clase cliente como contra la clase de servicio ya que implementa la interfaz con el cliente, mientras en vuelve el objeto de la clase de servicio. La clase adaptadora recibe llamadas del cliente a trav茅s de la interfaz adaptadora y las traduce en llamadas al objetyo envuelto de la clase de servicio, pero en un formato que pueda comprender.
5. El c贸digo cliente no se acopla a la clase adaptadora concreta siempre y cuando funcione con la clase adaptadora a trav茅s de la interfaz con el cliente. Gracias a esto puedes introducir nuevos tipos de adaptadores en el programa sin descomponer el c贸digo cliente existente. Esto puede resultar muy 煤til cuando la interfaz de la clase de servicio se cambia o sustituye, ya que puedes crear una nueva clase adaptadora sin cambiar el c贸digo cliente.

### Clase adaptadora

Esta implementaci贸n utiliza la herencia, porque la clase adaptadora hereda interfaces de ambos objetos al mismo tiempo. Ten en cuenta que esta opci贸n s贸lo puede implementarse en lenguajes de programaci贸n que soporten la herencia m煤ltiple, como C++.


![](https://refactoring.guru/images/patterns/diagrams/adapter/structure-class-adapter.png)

1. La **clase adaptadora** no necesita envolver objetos porque hereda comportamientos tando de la clase cliente como de la clase de servicio. La adaptacion tiene lugar dentro de los m茅todos dsobreescritos. La clase adaptadora resultante puede utilzarse en lugar de una clase cliente existente.
****

[Ejemplo estructural en c#](CodeExample\AdapterStructuralCode\Program.cs)

[Ejemplo practico en c#](CodeExample\RealWorldExample\Program.cs)

* * * * *
## 鈿? Pros y Contras

鉁? Principio de responsabilidad 煤nica. Puedes separar la interfaz o el c贸digo de conversi贸n de datos de la l贸gica de negocio primaria del programa.

鉁? Principio de abierto/cerrado. Puedes introducir nuevos tipos de adaptadores al programa sin descomponer el c贸digo cliente existente, siempre y cuando trabajen con los adaptadores a trav茅s de la interfaz con el cliente. 

鉂? La complejidad general del c贸digo aumenta, ya que debes introducir un grupo de nuevas interfaces y clases. En ocasiones resulta m谩s sencillo cambiar la clase de servicio de modo que coincida con el resto de tu c贸digo.


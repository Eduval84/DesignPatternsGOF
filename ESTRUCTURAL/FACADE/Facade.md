# **Facade**
## 📖Definicón

**Facade** es un patrón de diseño estructural que proporciona una interfaz simplificada a una biblioteca, un framework o cualquier otro grupo complejo de clases.

Complejidad

🟥⬛⬛

Popularidad

💚💚🖤

***

😟**Problema** 

Imagina que debes lograr que tu código trabaje con un amplio grupo de objetos que pertenecen a una sofisticada biblioteca o framework. Normalmente, debes inicializar todos esos objetos, llevar un registro de las dependencias, ejecutar los métodos en el orden correcto y así sucesivamente.

Como resultado, la lógica de negocio de tus clases se vería estrechamente acoplada a los detalles de implementación de las clases de terceros, haciéndola difícil de comprender y mantener.


😄**Solución** 

Una fachada es una clase que proporciona una interfaz simple a un subsistema complejo que contiene muchas partes móviles. Una fachada puede proporcionar una funcionalidad limitada en comparación con trabajar directamente con el subsistema. Sin embargo, tan solo incluye las funciones realmente importantes para los clientes.

Tener una fachada resulta útil cuando tienes que integrar tu aplicación con una biblioteca sofisticada con decenas de funciones, de la cual sólo necesitas una pequeña parte.

Por ejemplo, una aplicación que sube breves vídeos divertidos de gatos a las redes sociales, podría potencialmente utilizar una biblioteca de conversión de vídeo profesional. Sin embargo, lo único que necesita en realidad es una clase con el método simple codificar(nombreDelArchivo, formato). Una vez que crees dicha clase y la conectes con la biblioteca de conversión de vídeo, tendrás tu primera fachada.

**Ejemplos de uso:** 

El patrón Facade se utiliza habitualmente en aplicaciones escritas en C#. Es de especial utilidad al trabajar con bibliotecas y API complejas.

**Identificación:**

El patrón Facade se puede reconocer en una clase con una interfaz simple, pero que delega la mayor parte del trabajo a otras clases. Normalmente, las fachadas gestionan todo el ciclo de vida de los objetos que utilizan.

* * * * *

## 💡 Aplicabilidad

*  **El patrón Facade se utiliza cuando necesitemos una interfaz limitada pero directa a un subsistema complejo.**

    ⚡ * A menudo los subsistemas se vuelven más complejos con el tiempo. Incluso la aplicación de patrones de diseño suele conducir a la creación de un mayor número de clases. Un subsistema puede hacerse más flexible y más fácil de reutilizar en varios contextos, pero la cantidad de código de configuración que exige de un cliente, crece aún más. El patrón Facade intenta solucionar este problema proporcionando un atajo a las funciones más utilizadas del subsistema que mejor encajan con los requisitos del cliente.  

  *  **Utiliza el patrón Facade cuando quieras estructurar un subsistema en capas.**

     ⚡ * Crea fachadas para definir puntos de entrada a cada nivel de un subsistema. Puedes reducir el acoplamiento entre varios subsistemas exigiéndoles que se comuniquen únicamente mediante fachadas.

      Por ejemplo, regresemos a nuestro framework de conversión de vídeo. Puede dividirse en dos capas: la relacionada con el vídeo y la relacionada con el audio. Puedes crear una fachada para cada capa y hacer que las clases de cada una de ellas se comuniquen entre sí a través de esas fachadas. Este procedimiento es bastante similar al patrón **Mediator**.

* * * * *
## Estructura

![](https://refactoring.guru/images/patterns/diagrams/facade/structure.png)

1. El patrón **Facade** proporciona un práctico acceso a una parte especifica de la funcionalidad del subsitema. Sabe a dónde dirigir la peticion del cliente y como operar todas las partes móviles.
2. Puede crearse una clase **Fachada Adicional** para evitar contaminar una única fachada con funciones no relacionadas que podrían convertirla en otra estructura compleja. Las fachadas adicionales pueden utilizarse por clientes y por otras fachadas.
3. El **Subsistema Complejo** consiste en decenas de objetos diversos. Para lograr que todos hagan algo significativo, debes profundizar en los detalles de implementación del subsistema, que pueden incluir inicializar objetos en el orden correcto y suministrarles datos en el formato adecuado.
Las clases del subsistema no conocen la existencia de la fachada. Operan dentro del sistema y trabajan entre sí directamente.
4. El **Cliente** utiliza la fachada en lugar de invocar directamente los objetos del subsistema.

## Ejemplo UML real (Pseudocódigo)

En este ejemplo, el patrón Facade simplifica la interacción con un framework complejo de conversión de vídeo.

![](https://refactoring.guru/images/patterns/diagrams/facade/example.png)

Un ejemplo de aislamiento de múltiples dependencias dentro de una única clase fachada.

En lugar de hacer que tu código trabaje con decenas de las clases del framework directamente, creas una clase fachada que encapsula esa funcionalidad y la esconde del resto del código. Esta estructura también te ayuda a minimizar el esfuerzo de actualizar a futuras versiones del framework o de sustituirlo por otro. Lo único que tendrías que cambiar en la aplicación es la implementación de los métodos de la fachada.

[Ejemplo estructural (pseudocoódigo) en c#](CodeExample/RealWorldExample/Facade.cs)

[Ejemplo real en c#](CodeExample/Facade/FacadeConceptualExample.cs)

* * * * *
## ⚖ Pros y Contras

✔ Puedes aislar tu código de la complejidad de un subsistema.

❌ Una fachada puede convertirse en un objeto todopoderoso acoplado a todas las clases de una aplicación.
# **BRIDGE**
## 📖Definicón

Permite dividir una clase grande o un grupo de clases que estan estrechamente relacionadas entre si, en dos jerarquias separadas (abstraccion e implementacion) que pueden desarrollarse independientemente una de la otra.

Complejidad

🟥🟥⬛

Popularidad

💚🖤🖤
***
😟**Problema** 

¿Abstraccion? ¿Implementacion? Veamos un ejemplo sencillo

Digamos que tenemos una clase geometrica "Forma" con un par de subclases: Circulo y Cuadrado. Deseamos extender esta jerarquia de clase para que incorpore colores, por lo que planeamos crear las subclases de forma Rojo y Azul. Sin embargo como ya tenemos dos subclases, tenemos que crear cuatro combinaciones de las mismas :

![](https://refactoring.guru/images/patterns/diagrams/bridge/problem-es.png)

Esto hace que la jerarquia creazca exponencialmente, si quisieramos añadir una forma de triangulo o de rombo tendriamos que introducir dos clases mas por cada una de ellas y cuanto mas poligonos creemos mas crecera. 

😄**Solución** 

El problema es que hemos intentado extender las clases en dos dimensiones independientes:por forma y color. Es un problema muy habitual en la herencia de clases.

El patron Bridge intenta resolver este problema pasando de la herencia a la composicion del objeto. Se extrae una de las dimensiones a una jerarquia de clases separada, de modo que las clases originales referencian a un objeto de la nueva jerarquia, en lugar de tener todo su estado y sus funcionalidades dentro de la clase:

![](https://refactoring.guru/images/patterns/diagrams/bridge/solution-es.png)

Con este patron extraemos el código relacionado con el color y lo colocamos en su propia clase, con dos subclases rojo y azul. La clase Forma tiene un campo de referencia que apunta a uno de los objetos de color, delegando asi cualquier trabajo relacionado con el color al objeto de color vinculado creando asi una referencia que actua como puente entre las dos clases forma y color. 

***

**Ejemplos de uso:** 

El patrón Bridge es de especial utilidad a la hora de tratar con aplicaciones multiplataforma, soportar varios tipos de servidores de bases de datos, o trabajar con varios proveedores de API de un cierto tipo (por ejemplo, plataformas en la nube, redes sociales, etc.).

**Identificación:**

El patrón Bridge se puede reconocer por una distinción clara entre alguna entidad controladora y varias plataformas diferentes en las que se basa.

* * * * *
## 💡 Aplicabilidad

*  **Utiliza el patrón Bridge cuando quieras dividir y organizar una clase monolítica que tenga muchas variantes de una sola funcionalidad (por ejemplo, si la clase puede trabajar con diversos servidores de bases de datos).**
   
    ⚡ * Conforme más crece una clase, más dificl es comprender como funciona y se tarda más tiempo en realizar un cambio. Cambiar una de las variaciones de la funcionalidad puede exigir realizar muchos cambios a toda la clase, lo que a menudo provoca que se cometan errores o no se aborden algunos efectos colaterales.

    Con el patron Bridge podemos dividir la clase monolitica en varias jerarquias de clase. Después, podemos cambiar las clases de cada jerajquia independientemente sin afectar a las otras. Esta solución simplifica el mantenimiento del código y minimiza el riesgo de descomponer el código existente.

*  **Utilizar el patrón cuando necesitemos extender una clase en varias dimensiones independientes.**

    ⚡ * El patron Bridge sugiere que estraigamos una jerarquia de clase separa para cada una de las dimensiones. La clase original delega el trabajo relacionado a los objetos pertenecientes a dichas jerarquias, en vez de hacerlo todo ella por su cuenta.

*  **Utilizar el patrón cuando necesitemos poder cambiar implementaciones durante el tiempo de ejecución.**

    ⚡ * Aunque es opcional, el patrón Bridge te permite sustituir el objeto de implementación dentro de la abstracción. Es tan sencillo como asignar un nuevo valor a un campo.

    Por cierto, este último punto es la razón principal por la que tanta gente confunde el patrón Bridge con el patrón Strategy. Recuerda que un patrón es algo más que un cierto modo de estructurar tus clases. También puede comunicar intención y el tipo de problema que se está abordando.
* * * * *
## Estructura

![](https://refactoring.guru/images/patterns/diagrams/bridge/structure-es.png)

1. La **Abstracción** ofrece lógica de control de alto nivel. Depende de que el objeto de la implementacion haga el trabajo de bajo nivel
2. La **Implementación** declara la interfaz común a todas las implementaciones concretas. Una abstraccion sólo se puede comunciar con un objeto de implementación a través de los métodos que se declaren aqui. La abstracción puede enumerar los mismos métodos que la implementación, pero normalente ladeclara funcionalidades complejas que dependen de una amplia variedad de operaciones primitivas declaradas por la implementación.
3. Las **implementaciones** concretas contienen código especifico de plataforma.
4. Las **abstracciones refinadas** proporcionan variantes de lógica de control. Como sus padres trabajan con distintas implementaciones a través de la interfaz general deimplementación.
5. Normalmente el **cliente** sólo está interesado en trabajar con la abstracción. No obstante, el cliente tiene que vincular el bojeto de la abstracción con uno de los objetos de la implementación.

## Ejemplo UML real 

![](https://refactoring.guru/images/patterns/diagrams/bridge/example-es.png)

[Ejemplo estructural en c#](CodeExample/BridgeStructuralCode/Program.cs)

[Ejemplo real en c#](CodeExample/RealWorldExample/Program.cs)

* * * * *
## ⚖ Pros y Contras

✔ Puedes crear clases y aplicaciones independientes de plataforma.

✔ El código cliente funciona
  
✔ con abstracciones de alto nivel. No está expuesto a los detalles de la plataforma.

✔ Principio de abierto/cerrado. Puedes introducir nuevas abstracciones e implementaciones independientes entre sí.

✔ Principio de responsabilidad única. Puedes centrarte en la lógica de alto nivel en la abstracción y en detalles de la plataforma en la implementación.

❌ Puede ser que el código se complique si aplicas el patrón a una clase muy cohesionada.
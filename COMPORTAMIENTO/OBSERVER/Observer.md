# **Memento**
## 📖Definicón

**Memento** es un patrón de diseño de comportamiento que te permite guardar y restaurar el estado previo de un objeto sin revelar los detalles de su implementación.


Complejidad

🟥🟥🟥

Popularidad

💚🖤🖤

***

😟**Problema** 

Imagina que estás creando una aplicación de edición de texto. Además de editar texto, tu programa puede formatearlo, asi como insertar imágenes en línea, etc.

En cierto momento, decides permitir a los usuarios deshacer cualquier operación realizada en el texto. Esta función se ha vuelto tan habitual en los últimos años que hoy en día todo el mundo espera que todas las aplicaciones la tengan. Para la implementación eliges la solución directa. Antes de realizar cualquier operación, la aplicación registra el estado de todos los objetos y lo guarda en un almacenamiento. Más tarde, cuando un usuario decide revertir una acción, la aplicación extrae la última instantánea del historial y la utiliza para restaurar el estado de todos los objetos.

![](https://refactoring.guru/images/patterns/diagrams/memento/problem1-es.png)
Antes de ejecutar una operación, la aplicación guarda una instantánea del estado de los objetos, que más tarde se puede utilizar para restaurar objetos a su estado previo.

Pensemos en estas instantáneas de estado. ¿Cómo producirías una, exactamente? Probablemente tengas que recorrer todos los campos de un objeto y copiar sus valores en el almacenamiento. Sin embargo, esto sólo funcionará si el objeto tiene unas restricciones bastante laxas al acceso a sus contenidos. Lamentablemente, la mayoría de objetos reales no permite a otros asomarse a su interior fácilmente, y esconden todos los datos significativos en campos privados.

Ignora ese problema por ahora y asumamos que nuestros objetos se comportan como hippies: prefieren relaciones abiertas y mantienen su estado público. Aunque esta solución resolvería el problema inmediato y te permitiría producir instantáneas de estados de objetos a voluntad, sigue teniendo algunos inconvenientes serios. En el futuro, puede que decidas refactorizar algunas de las clases editoras, o añadir o eliminar algunos de los campos. Parece fácil, pero esto también exige cambiar las clases responsables de copiar el estado de los objetos afectados.

![](https://refactoring.guru/images/patterns/diagrams/memento/problem2-es.png)
¿Cómo hacer una copia del estado privado del objeto?

Pero aún hay más. Pensemos en las propias “instantáneas” del estado del editor. ¿Qué datos contienen? Como mínimo, deben contener el texto, las coordenadas del cursor, la posición actual de desplazamiento, etc. Para realizar una instantánea debes recopilar estos valores y meterlos en algún tipo de contenedor.

Probablemente almacenarás muchos de estos objetos de contenedor dentro de una lista que represente el historial. Por lo tanto, probablemente los contenedores acaben siendo objetos de una clase. La clase no tendrá apenas métodos, pero sí muchos campos que reflejen el estado del editor. Para permitir que otros objetos escriban y lean datos a y desde una instantánea, es probable que tengas que hacer sus campos públicos. Esto expondrá todos los estados del editor, privados o no. Otras clases se volverán dependientes de cada pequeño cambio en la clase de la instantánea, que de otra forma ocurriría dentro de campos y métodos privados sin afectar a clases externas.

Parece que hemos llegado a un callejón sin salida: o bien expones todos los detalles internos de las clases, haciéndolas demasiado frágiles, o restringes el acceso a su estado, haciendo imposible producir instantáneas. ¿Hay alguna otra forma de implementar el "deshacer"?

😄**Solución** 

Todos los problemas que hemos experimentado han sido provocados por una encapsulación fragmentada. Algunos objetos intentan hacer más de lo que deben. Para recopilar los datos necesarios para realizar una acción, invaden el espacio privado de otros objetos en lugar de permitir a esos objetos realizar la propia acción.

El patrón Memento delega la creación de instantáneas de estado al propietario de ese estado, el objeto originador. Por lo tanto, en lugar de que haya otros objetos intentando copiar el estado del editor desde el “exterior”, la propia clase editora puede hacer la instantánea, ya que tiene pleno acceso a su propio estado.

El patrón sugiere almacenar la copia del estado del objeto en un objeto especial llamado memento. Los contenidos del memento no son accesibles para ningún otro objeto excepto el que lo produjo. Otros objetos deben comunicarse con mementos utilizando una interfaz limitada que pueda permitir extraer los metadatos de la instantánea (tiempo de creación, el nombre de la operación realizada, etc.), pero no el estado del objeto original contenido en la instantánea.

![](https://refactoring.guru/images/patterns/diagrams/memento/solution-es.png)

El originador tiene pleno acceso al memento, mientras que el cuidador sólo puede acceder a los metadatos.

Una política tan restrictiva te permite almacenar mementos dentro de otros objetos, normalmente llamados cuidadores. Debido a que el cuidador trabaja con el memento únicamente a través de la interfaz limitada, no puede manipular el estado almacenado dentro del memento. Al mismo tiempo, el originador tiene acceso a todos los campos dentro del memento, permitiéndole restaurar su estado previo a voluntad.

En nuestro ejemplo del editor de texto, podemos crear una clase separada de historial que actúe como cuidadora. Una pila de mementos almacenados dentro de la cuidadora crecerá cada vez que el editor vaya a ejecutar una operación. Puedes incluso presentar esta pila dentro de la UI de la aplicación, mostrando a un usuario el historial de operaciones previamente realizadas.

Cuando un usuario activa la función Deshacer, el historial toma el memento más reciente de la pila y lo pasa de vuelta al editor, solicitando una restauración. Debido a que el editor tiene pleno acceso al memento, cambia su propio estado con los valores tomados del memento.

* * * * *

## 💡 Aplicabilidad

*  **Utiliza el patrón Memento cuando quieras producir instantáneas del estado del objeto para poder restaurar un estado previo del objeto.**

    ⚡ El patrón Memento te permite realizar copias completas del estado de un objeto, incluyendo campos privados, y almacenarlos independientemente del objeto. Aunque la mayoría de la gente recuerda este patrón gracias al caso de la función Deshacer, también es indispensable a la hora de tratar con transacciones (por ejemplo, si debes volver atrás sobre un error en una operación)..

*  **Utiliza el patrón cuando el acceso directo a los campos, consultores o modificadores del objeto viole su encapsulación.**

    ⚡El Memento hace al propio objeto responsable de la creación de una instantánea de su estado. Ningún otro objeto puede leer la instantánea, lo que hace que los datos del estado del objeto original queden seguros.

* * * * *
## Estructura
**Implementación basada en clases anidadas**

![](https://refactoring.guru/images/patterns/diagrams/mediator/structure.png)

1.La clase **Originadora** puede producir instantáneas de su propio estado, así como restaurar su estado a partir de instantáneas cuando lo necesita.
   
2. El **Memento** es un objeto de valor que actúa como instantánea del estado del originador. Es práctica común hacer el memento inmutable y pasarle los datos solo una vez, a través del constructor.

3. La **Cuidadora** sabe no solo “cuándo” y “por qué” capturar el estado de la originadora, sino también cuándo debe restaurarse el estado.

4.En esta implementación, la clase memento se anida dentro de la originadora. Esto permite a la originadora acceder a los campos y métodos de la clase memento, aunque se declaren privados. Por otro lado, la cuidadora tiene un acceso muy limitado a los campos y métodos de la clase memento, lo que le permite almacenar mementos en una pila pero no alterar su estado.

**Implementación basada en una interfaz intermedia**

![](https://refactoring.guru/images/patterns/diagrams/memento/structure2.png)

Existe una implementación alternativa, adecuada para lenguajes de programación que no soportan clases anidadas (sí, PHP, estoy hablando de ti).

1.En ausencia de clases anidadas, puedes restringir el acceso a los campos de la clase memento estableciendo una convención de que las cuidadoras sólo pueden trabajar con una memento a través de una interfaz intermediaria explícitamente declarada, que sólo declarará métodos relacionados con los metadatos del memento.
   
2. Por otro lado, las originadoras pueden trabajar directamente con un objeto memento, accediendo a campos y métodos declarados en la clase memento. El inconveniente de esta solución es que debes declarar públicos todos los miembros de la clase memento.

**Implementación con una encapsulación más estricta**

![](https://refactoring.guru/images/patterns/diagrams/memento/structure3.png)

Existe una implementación alternativa, adecuada para lenguajes de programación que no soportan clases anidadas (sí, PHP, estoy hablando de ti).

1.Esta implementación permite tener varios tipos de originadoras y mementos. Cada originadora trabaja con una clase memento correspondiente. Ninguna de las dos expone su estado a nadie.
   
2. Las cuidadoras tienen ahora explícitamente restringido cambiar el estado almacenado en los mementos. Además, la clase cuidadora se vuelve independiente de la originadora porque el método de restauración se define ahora en la clase memento.

3.Cada memento queda vinculado a la originadora que lo produce. La originadora se pasa al constructor del memento, junto con los valores de su estado. Gracias a la estrecha relación entre estas clases, un memento puede restaurar el estado de su originadora, siempre que esta última haya definido los modificadores (setters) adecuados.


## Ejemplo UML real (Pseudocódigo)

Este ejemplo utiliza el patrón Memento junto al patrón **Command** para almacenar instantáneas del estado complejo del editor de texto y restaurar un estado previo a partir de estas instantáneas cuando sea necesario.

![](https://refactoring.guru/images/patterns/diagrams/mediator/example.png)

Los objetos de comando actúan como cuidadores. Buscan el memento del editor antes de ejecutar operaciones relacionadas con los comandos. Cuando un usuario intenta deshacer el comando más reciente, el editor puede utilizar el memento almacenado en ese comando para revertirse a sí mismo al estado previo.

La clase memento no declara ningún campo, consultor (getter) o modificador (setter) como público. Por lo tanto, ningún objeto puede alterar sus contenidos. Los mementos se vinculan al objeto del editor que los creó. Esto permite a un memento restaurar el estado del editor vinculado pasando los datos a través de modificadores en el objeto editor. Ya que los mementos están vinculados a objetos de editor específicos, puedes hacer que tu aplicación soporte varias ventanas de editor independientes con una pila centralizada para deshacer.

[Ejemplo estructural (pseudocoódigo) en c#](CodeExample/RealWorldExample/Memento.cs)

[Ejemplo real en c#](CodeExample/Memento/Memento.cs)

* * * * *
## ⚖ Pros y Contras

✔ Puedes producir instantáneas del estado del objeto sin violar su encapsulación.

✔ Puedes simplificar el código de la originadora permitiendo que la cuidadora mantenga el historial del estado de la originadora.

❌  La aplicación puede consumir mucha memoria RAM si los clientes crean mementos muy a menudo.

❌ Las cuidadoras deben rastrear el ciclo de vida de la originadora para poder destruir mementos obsoletos.
 
❌ La mayoría de los lenguajes de programación dinámicos, como PHP, Python y JavaScript, no pueden garantizar que el estado dentro del memento se mantenga intacto.


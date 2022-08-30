# **BRIDGE**
## 📖Definicón

Permite dividir una clase grande o un grupo de clases que estan estrechamente relacionadas entre si, en dos jerarquias separadas (abstraccion e implementacion) que pueden desarrollarse independientemente una de la otra.

Complejidad

🟥🟥⬛

Popularidad

💚🖤🖤

**Ejemplos de uso:** 

El patrón Bridge es de especial utilidad a la hora de tratar con aplicaciones multiplataforma, soportar varios tipos de servidores de bases de datos, o trabajar con varios proveedores de API de un cierto tipo (por ejemplo, plataformas en la nube, redes sociales, etc.).

**Identificación:**

El patrón Bridge se puede reconocer por una distinción clara entre alguna entidad controladora y varias plataformas diferentes en las que se basa.

* * * * *
## 💡 Aplicabilidad

*  **Utiliza el patrón Bridge cuando quieras dividir y organizar una clase monolítica que tenga muchas variantes de una sola funcionalidad (por ejemplo, si la clase puede trabajar con diversos servidores de bases de datos).**
*  
  ⚡ * Conforme más crece una clase, más dificl es comprender como funciona y se tarda más tiempo en realizar un cambio. Cambiar una de las variaciones de la funcionalidad puede exigir realizar muchos cambios a toda la clase, lo que a menudo provoca que se cometan errores o no se aborden algunos efectos colaterales.

  Con el patron Bridge podemos dividir la clase monolitica en varias jerarquias de clase. Después, podemos cambiar las clases de cada jerajquia independientemente sin afectar a las otras. Esta solución simplifica el mantenimiento del código y minimiza el riesgo de descomponer el código existente.

  *  **Utilizar el patrón cuando necesitemos extender una clase en varias dimensiones independientes.**

  ⚡ * El patron Bridge sugiere que estraigamos una jerarquia de clase separa para cada una de las dimensiones. La clase original delega el trabajo relacionado a los objetos pertenecientes a dichas jerarquias, en vez de hacerlo todo ella por su cuenta.

  *  **Utilizar el patrón cuando necesitemos poder cambiar implementaciones durante el tiempo de ejecución.**

 ⚡ * Aunque es opcional, el patrón Bridge te permite sustituir el objeto de implementación dentro de la abstracción. Es tan sencillo como asignar un nuevo valor a un campo.

Por cierto, este último punto es la razón principal por la que tanta gente confunde el patrón Bridge con el patrón Strategy. Recuerda que un patrón es algo más que un cierto modo de estructurar tus clases. También puede comunicar intención y el tipo de problema que se está abordando.
* * * * *
## Estructura

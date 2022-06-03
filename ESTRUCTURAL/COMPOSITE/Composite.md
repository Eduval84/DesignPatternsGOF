**COMPOSITE**
* * * * *

###Definicion

Permite componer objetos en estructuras de arbol para representar jerarquieas y trabajar como si fueran objetos individuales y composiciones de objetos de manera uniforme.

Complejidad:

🟥🟥⬛

Popularidad:

💚💚🖤
* * * * *
💡 Aplicabilidad

*  **Usar el patron Composite cuando el modelo central de tu aplicación puede representarse en una estructura de objetos en forma de arbol.**

   ⚡ *  Este patrón te proporciona dos tipos de elementos basicos que comarten una interfaz común: hojas(leaf) simples y contenedores complejos. Un contenedor puede estar compuesto por hojas y por otros contenedores. Esto te permite construir una estructrua de objetos recursivos anidados.

* **Utila el patrón cuando quieras que el código cliente trate elementos simples y compejos de la misma forma**

   ⚡ *  Al compartir un interfaz común el cliente no tiene que preocuparse por la clase concreta de los objetos con los que funciona.
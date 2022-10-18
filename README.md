GOF patterns
------

Los patrones de diseño son soluciones habituales y probadas, a problemas comunes de diseño de software.

Los 23 patrones de Gang of Four (GoF) generalmente se consideran la base para todos los demás patrones. Se clasifican en tres grupos: creacionales, estructurales y de comportamiento.

## Ventajas
Te enseñan a resolver todo tipo de problemas utilizando principios del diseño orientado a objetos.

Los patrones de diseño definen un lenguaje común que puedes utilizar con tus compañeros de equipo para comunicaros de forma más eficiente. 

## Desventajas
Maluso o un uso desmesurado, es un problema muy comun sobre todo cuando empiezas a aprender sobre patrones de diseño porque intentas aplicarlos en todas partes, incluso en situaciones en las que un codigo mas simple funciona bien. "El tipico ejemplo de que cuando tienes un martillo, todo son clavos"

Desfasados o desactualizados, es decir hay patrones que han pasado a formar parte de las caracteristicas de los lenguajes por ejemplo hoy en dia el patrón **[Strategy](Comportamiento/Strategy.md)** puede implementarse con una simple función anónima (lambda) en la mayoría de lenguajes de programación modernos.

Soluciones ineficientes o cerradas sin margen de mejora, Los patrones intentan sistematizar soluciones cuyo uso ya es generalizado. Esta unificación es vista por muchos como un dogma, e implementan los patrones “al pie de la letra”, sin adaptarlos al contexto del proyecto particular.

## Patrones Creacionales
Proporcionan varios mecanismos de creacion de objetos que incrementan la flexibilidad y la reutilización del código existente.
* [Abstract Factory](Creacional/AbstractFactory.md)
* [Builder](Creacional/Builder.md)
* [Factory Method](Creacional/FactoryMethod.md)
* [Prototype](Creacional/Prototype.md)
* [Singleton](Creacional/Singleton.md)

## Patrones Estructurales
Explican como ensamblar objetos y clases en estructuras mas grandes, a la vez que se mantiene la flexibilidad y eficiencia de estas estructuras.
* [Adapter](ESTRUCTURAL/ADAPTER/Adapter.md)
* [Bridge](ESTRUCTURAL/BRIDGE/Bridge.md)
* [Composite](ESTRUCTURAL/COMPOSITE/Composite.md)
* [Decorator](ESTRUCTURAL/DECORATOR/Decorator.md)
* [Facade](ESTRUCTURAL/FACADE/Facade.md)
* [Flyweight](ESTRUCTURAL/FLYWEIGHT/Flyweight.md)
* [Proxy](ESTRUCTURAL/PROXY/Proxy.md)

## Patrones de comportamiento
Tratan con algoritmos y la asignacion de responsabilidades dentre objetos.
* [Chain of Responsibility](COMPORTAMIENTO/CHAINOFRESPONSIBILITY/ChainOfResponsibility.md)
* [Command](COMPORTAMIENTO/COMMAND/Command.md)
* [Interpreter](COMPORTAMIENTO/Interpreter.md)
* [Iterator](COMPORTAMIENTO/ITERATOR/Iterator.md)
* [Mediator](COMPORTAMIENTO/Mediator.md)
* [Memento](COMPORTAMIENTO/MEMENTO/Memento.md)
* [Observer](COMPORTAMIENTO/OBSERVER/Observer.md)
* [State](COMPORTAMIENTO/STATE/State.md)
* [Strategy](COMPORTAMIENTO/Strategy.md)
* [Template Method](COMPORTAMIENTO/TemplateMethod.md)
* [Visitor](COMPORTAMIENTO/Visitor.md)

## License
* [RefactoringGuru](https://refactoring.guru/es/design-patterns/csharp)
* [DoFactory](https://www.dofactory.com/net/design-patterns)
* [Design Patterns: Elements of Reusable Object-Oriented Software (Addison Wesley professional computing series)](https://www.amazon.es/Design-Patterns-Object-Oriented-professional-computing/dp/0201633612/ref=asc_df_0201633612/?tag=googshopes-21&linkCode=df0&hvadid=54582498915&hvpos=&hvnetw=g&hvrand=11090694101626356639&hvpone=&hvptwo=&hvqmt=&hvdev=c&hvdvcmdl=&hvlocint=&hvlocphy=1005493&hvtargid=pla-83983370726&psc=1)

# Ejercicio 1: Diseño de nivel

## Descripción general
El nivel está diseñado como un seem endless runner con combate.  
El jugador comienza saliendo de su base montado en su moto. Mientras avanza, debe esquivar obstáculos en la carretera (barreras y grietas) y recoger combustible.  
A medida que progresa, aparecen enemigos que intentan derribarlo. Derrotarlos proporciona combustible adicional.  
En un punto determinado del nivel, se introduce la mecánica de reparación de la moto. El jugador recibe una gran cantidad de daño inevitable, lo que le obliga a abandonar la moto y continuar a pie hasta repararla.  
Tras completar la reparación, el jugador vuelve a la moto y continúa avanzando, consolidando todas las mecánicas aprendidas hasta llegar al final del nivel.

## Estructura del nivel

El nivel se divide en las siguientes etapas:

- Inicio  
  - Movimiento básico en moto  
  - Sin enemigos  
  - Obstáculos simples (barreras, grietas)  
  - Introducción al esquive  
  - Objetivo: aprender los controles básicos  

- Tramo de velocidad  
  - Introducción a la aceleración  
  - Aparición del sistema de combustible  
  - Incremento ligero de dificultad  
  - Objetivo: comprender la relación entre velocidad y consumo  

- Zona de combate  
  - Aparición de enemigos  
  - Introducción al sistema de combate  
  - Objetivo: derrotar enemigos y sobrevivir  
  - Recompensa: obtención de combustible  

- Zona de reparación  
  - Evento forzado de daño  
  - La moto queda inutilizada  
  - Cambio a modo a pie  
  - Objetivo: reparar la moto  
  - Recompensa: recuperar la movilidad  

- Reanudación  
  - Regreso al modo moto  
  - Aumento progresivo de dificultad  
  - Integración de todas las mecánicas  
  - Objetivo: completar el nivel  
  - Recompensa: acceso al siguiente nivel  

## Objetivos del nivel

- Aprender las mecánicas básicas de movimiento y aceleración  
- Introducir el sistema de combate  
- Enseñar la mecánica de reparación de la moto  
- Aprender la gestión del combustible  
- Superar el nivel combinando todas las mecánicas  

## Obstáculos

- Barreras/grietas  
- Enemigos  

## Eventos de ambiente / scripting

- Spawn de enemigos  
- Daño forzado de la moto  


# Ejercicio 2: Características del nivel

## Entorno

- Tipo: exterior  
- Contexto: fantasía con elementos industriales  
- Época: ambientación medieval fantástica con tecnología anacrónica  

El nivel se desarrolla en un entorno exterior con mezcla de fantasía y elementos industriales.  
Se trata de una carretera o línea de montaje que atraviesa inicialmente una fábrica o castillo, que actúa como base del protagonista, y continúa hasta un pequeño poblado habitado por robots.  

El entorno combina arquitectura medieval con maquinaria avanzada, generando un contraste visual entre lo antiguo y lo tecnológico.

## Ubicación

La acción tiene lugar en una carretera o camino principal que conecta la base del jugador con diferentes aldeas o zonas ricas en recursos.

Elementos clave de la ubicación:

- Base inicial: zona segura (fábrica o castillo del protagonista)  
- Camino principal: eje de progresión del nivel  
- Tramos destruidos: grietas, obstáculos y partes deterioradas del camino  
- Zonas de combate: áreas donde el avance se ve interrumpido por enemigos  

La ubicación está diseñada de forma lineal para guiar al jugador mientras introduce progresivamente las mecánicas del juego.

## Temática

La temática del nivel gira en torno al saqueo y la conquista.  
El jugador encarna a un guerrero con una mentalidad similar a la de un vikingo, cuyo objetivo es avanzar, derrotar enemigos y obtener recursos para continuar su viaje.  

Se busca transmitir:

- Sensación de avance constante hacia territorios hostiles  
- Motivación basada en la obtención de recursos (combustible)  
- Un estilo de juego agresivo y dinámico  
- La idea de conquista de zonas dominadas por enemigos  

Esta temática refuerza el ritmo del juego y justifica tanto el combate como la exploración lineal del entorno.


# Ejercicio 3: referencias visuales

Para el diseño visual del nivel se han tomado como referencia diversas fuentes procedentes de la música, los videojuegos, el cine y los juegos de mesa, con el objetivo de construir una identidad estética coherente que combine fantasía clásica, ciencia ficción y un tono épico.

## Música

En el ámbito musical, bandas como Gloryhammer y, en general, el género power metal, han servido como principal inspiración estética. Este tipo de música se caracteriza por una temática épica y fantástica que mezcla elementos medievales con ciencia ficción, incluyendo conceptos como naves espaciales, tecnología avanzada y héroes arquetípicos. Esta combinación influye directamente en la dirección artística del proyecto, fomentando un estilo visual donde conviven armaduras fantásticas con tecnología futurista, generando un contraste llamativo y distintivo.

## Videojuegos

En cuanto a videojuegos, títulos como Deus Ex aportan una visión de un mundo dominado por la tecnología, donde el uso de implantes, sistemas avanzados y estética cyberpunk refuerzan la idea de un entorno tecnológicamente evolucionado. Por otro lado, Skyrim ofrece una referencia clave en cuanto a ambientación fantástica: paisajes naturales amplios, montañas imponentes, fauna salvaje y zonas que no han sido completamente dominadas por la civilización. Además, la épica narrativa y la sensación de aventura influyen en la forma en la que se construye el mundo y su atmósfera.

## Cine

En el cine, películas como Mad Max y Akira aportan referencias importantes en términos de ambientación post-apocalíptica y estética urbana futurista. Mad Max destaca por sus entornos desolados, vehículos modificados y sensación de supervivencia extrema. El Señor de los Anillos sirve como referencia en lo relativo a fantasía épica, diseño de escenarios naturales y construcción de un mundo coherente y detallado, con una fuerte presencia de mitología y narrativa ambiental.

## Otros

Los juegos de mesa como Warhammer 40.000 aportan una estética característica basada en la exageración visual. Sus diseños de personajes, vehículos y estructuras son altamente detallados y recargados, lo que contribuye a transmitir una sensación de poder, escala y dramatismo. Esta estética, aunque exagerada, resulta muy atractiva.


# Ejercicio 4: elementos

## Enemigos

| Tipo de enemigo | Descripción | Cuándo aparece | Dónde aparece | Función |
|----------------|------------|----------------|--------------|--------|
| Enemigo básico cuerpo a cuerpo | Unidad ligera que intenta derribar al jugador acercándose a su posición | Zona de combate | Todo el camino | Introducir combate básico |
| Enemigo a distancia | Ataca desde cierta distancia mediante proyectiles | Zona de combate | Laterales del camino | Obligar al jugador a esquivar mientras avanza |
| Enemigo pesado | Unidad con mayor resistencia y daño | Zona de combate | Puntos estratégicos del nivel | Actuar como desafío más exigente |
| Enemigo rápido | Unidad con alta velocidad que persigue al jugador | Tramos intermedios | Todo el camino | Aumentar la presión y dificultad |
| NPC enemigo inofensivo | Personaje no agresivo que no ataca al jugador | A lo largo del nivel | Zonas transitadas o laterales | Añadir variedad y decisiones al jugador; puede ser destruido para obtener recursos |

## Obstáculos

| Tipo de obstáculo | Descripción | Cuándo aparece | Dónde aparece | Función | Interacción / Resultado |
|------------------|------------|----------------|--------------|--------|------------------------|
| Casas | Estructuras destructibles del entorno | A lo largo del nivel | Laterales o en el camino | Actúan como recurso opcional para el jugador | Se pueden destruir si el jugador colisiona con suficiente velocidad o impacta antes de la colisión. Si se destruyen correctamente, otorgan oro. Si no se cumplen las condiciones, se destruyen igualmente pero el jugador recibe daño leve |
| Refinerías | Estructuras industriales destructibles | Zonas específicas del nivel | Laterales o en el camino | Actúan como recurso opcional para el jugador | Se pueden destruir si se impacta con suficiente velocidad o previamente. Si se destruyen correctamente, otorgan combustible. Si no, se destruyen igualmente pero el jugador recibe daño leve |
| Barreras | Obstáculos físicos que bloquean el avance | A lo largo del nivel | En el camino | Obstáculo principal de esquiva | Se pueden destruir bajo condiciones similares a casas/refinerías (impacto o velocidad suficiente). No proporcionan recursos. Si no se cumplen las condiciones, se destruyen pero infligen daño mayor al jugador |
| Grietas | Fallos en el terreno que interrumpen el recorrido | A lo largo del nivel | En el camino | Obstáculo principal de esquiva | No se pueden destruir ni interactuar con ellas. El daño recibido depende de la velocidad del jugador: a mayor velocidad, mayor daño |

## Premios

| Tipo de premio | Descripción | Cuándo aparece | Dónde aparece | Función |
|---------------|------------|----------------|--------------|--------|
| Combustible | Recurso principal que permite mantener en funcionamiento la moto | Durante todo el nivel al derrotar enemigos o destruir elementos como refinerías | En enemigos derrotados y refinerías | Gestión de recursos del jugador. Permite continuar avanzando en el nivel |
| Oro | Recurso utilizado únicamente como sistema de puntuación final | Durante todo el nivel al derrotar enemigos o destruir elementos como casas | En enemigos derrotados y casas | Determinar la puntuación final del jugador al completar el nivel |


# Ejercicio 5: Música y sonido

El diseño sonoro del nivel se estructura en función de las distintas fases del nivel, adaptando la música y los efectos de sonido a la situación del jugador.

## Tramo inicial (tutorial en moto)

- MX: Música ligera con ritmo progresivo que introduce al jugador en la dinámica del nivel, con un estilo tecno-mecánico que ambienta la zona inicial de fábrica.  
- BG: Sonido de engranajes, maquinaria en funcionamiento y soldaduras, junto con un ambiente general propio de una fábrica de ensamblaje.  
- SFX: Colisiones con obstáculos, interacciones con elementos del entorno y feedback de acciones básicas del jugador.  
- FOL: Sonido continuo del motor y de las ruedas de la moto, con variaciones leves en función del movimiento.  

## Tramo de velocidad y exploración

- MX: Música con mayor ritmo, presencia de percusión y mayor energía, acompañando el incremento de velocidad y dificultad. En este tramo se abandona el entorno de fábrica y se pasa a un ambiente exterior.  
- BG: Ambiente exterior constante que refuerza la sensación de espacio abierto, con predominio de sonidos de viento.  
- SFX: Uso de combustible, aceleración, frenado e interacciones con los obstáculos del entorno.  
- FOL: Variación dinámica del sonido del motor en función de la velocidad del jugador.  

## Zona de combate

- MX: Música intensa y dinámica orientada a la acción, con mayor carga rítmica y tensión.  
- BG: Ambiente más tenso que combina viento, maquinaria lejana y sonidos industriales.  
- SFX: Golpes, ataques, impactos y destrucción de enemigos.  
- FOL: Sonidos de movimiento tanto del jugador como de los enemigos.  
- DX: Posibles sonidos de alerta o feedback del sistema utilizados para reforzar eventos importantes. Los enemigos robotizados emiten sonidos no verbales o ilegibles como forma de comunicación.  

## Evento de daño forzado / transición a pie

- MX: Cambio musical que introduce tensión o una pausa parcial, marcando un punto importante en la progresión del nivel.  
- BG: Reducción del ambiente o transición hacia un entorno más calmado.  
- SFX: Sonido de impacto fuerte que desencadena el evento narrativo y mecánico.  
- DX: Aviso o feedback narrativo que comunica al jugador el cambio de estado.  
- FOL: Transición del sonido de la moto al sonido de los pasos del personaje.  

## Zona a pie

- MX: Música más contenida o ambiental, con menor intensidad, acompañando el cambio de ritmo del gameplay.  
- BG: Ambiente más silencioso o centrado en sonidos cercanos, reduciendo la densidad sonora general.  
- SFX: Interacciones básicas con el entorno y acciones del personaje a pie.  
- FOL: Sonidos de pasos del personaje y movimiento a pie.  
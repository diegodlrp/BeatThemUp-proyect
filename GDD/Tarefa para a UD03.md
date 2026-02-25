🧩 EJERCICIO 1 – MECÁNICAS

| Mecánica | Tipo | Necesidad | Reglas |
|----------|------|-----------|--------|
| **Conducción** | Primaria | Control posición<br>Control de velocidad<br>Integridad del vehículo | La moto avanza automáticamente a lo largo del nivel y no puede frenar ni retroceder. El jugador debe mantener la posición y la velocidad mientras evita obstáculos y proyectiles. Si la moto recibe demasiado daño, queda inutilizada hasta ser reparada. |
| **Control posición** | Secundaria | Movimiento arriba o abajo | El jugador solo puede controlar manualmente la posición de la moto en el eje vertical (arriba/abajo) para esquivar obstáculos o proyectiles. |
| **Control de velocidad** | Secundaria | Acelerar<br>Resistencia (físicas) | El jugador puede acelerar pero no frenar. La velocidad de la moto se determina mediante físicas realistas. A mayor velocidad, mayor dificultad de reacción y mayor consumo de combustible. |
| **Integridad del vehículo** | Secundaria | Sistema de colisiones y destrucción del vehículo<br>Sistema de reparación del vehículo | Si la moto recibe suficiente daño, queda destruida y debe ser reparada antes de volver a avanzar automáticamente. Durante la reparación, el caballero puede luchar a pie pero con movilidad limitada. |
| **Combate** | Primaria | Combate en moto<br>Combate a pie<br>Sistema de muerte y reinicio<br>Sistema de botín | El combate está activo en todo momento. Permite derrotar enemigos, recolectar combustible y mantener la progresión. |
| **Combate en moto** | Secundaria | Sistema de cálculo de daños<br>Puntos vida/muerte | La velocidad del vehículo influye positivamente en el daño de los ataques. Los enemigos pueden ser destruidos mientras el caballero conduce la moto. |
| **Combate a pie** | Secundaria | Sistema de cálculo de daños<br>Puntos vida/muerte | Si la moto queda inutilizada, el combate se realiza a pie. Más lento y débil que el combate sobre la moto, pero necesario para continuar avanzando. |
| **Sistema de muerte y reinicio** | Secundaria | Sistema de cálculo de daños<br>Puntos vida/muerte | El jugador solo puede “morir” cuando no está sobre la moto. Si recibe daño mientras conduce, este se aplica al vehículo. La muerte reinicia al jugador desde el último punto de control. |
| **Gestión combustible** | Primaria | Recolección de combustible<br>Gasto de combustible | El combustible es un recurso central. Se obtiene durante el nivel y se consume tanto de forma pasiva (moto) como activa (habilidades). Si se agota, la moto deja de avanzar automáticamente. |
| **Recolección de combustible** | Secundaria | Obtención por combate<br>Obtención por exploración<br>Obtención por destrucción de objetos | El combustible puede obtenerse derrotando enemigos (drop aleatorio o fijo), recogiendo depósitos distribuidos por el escenario o destruyendo cajas y cofres. Los enemigos más fuertes otorgan mayor cantidad de combustible. |
| **Gasto de combustible** | Secundaria | Consumo pasivo continuo<br>Consumo activo por habilidades | La moto consume combustible constantemente mientras está en funcionamiento. Además, el jugador puede gastar combustible para activar hechizos o habilidades especiales. Si no hay suficiente combustible, las habilidades no pueden utilizarse. |
| **Menús inmersivos tipo códice** | Terciaria | Interfaz narrativa y estética | Los menús y HUD se presentan como libros, pergaminos o manuscritos ilustrados. La navegación simula pasar páginas con animaciones, reforzando la ambientación medieval-industrial del juego. |
| **Sistema de rango de devastación** | Terciaria | Evaluación del rendimiento | Al finalizar cada nivel, se muestra un rango basado en tiempo, combustible recolectado y destrucción causada. Fomenta la rejugabilidad y optimización de niveles. |
| **Indicadores visuales de territorio** | Terciaria | Inmersión y narrativa ambiental | A medida que el jugador avanza, el reino se muestra más devastado visualmente (aldeas quemadas, carreteras destruidas). No afecta la mecánica directa, pero refuerza la narrativa del villano imparable. |


📊 Tabla de Mecánicas
Tipo	Mecánica	Descripción	Objetivo de Diseño
Primaria	Conducción automática	El caballo/moto avanza constantemente hacia la derecha	Mantener tensión continua
Primaria	Combate cuerpo a cuerpo	Ataques ligeros, pesados y combo en modo arena	Supervivencia y control del espacio
Primaria	Sistema de Corrupción	Cada enemigo derrotado aumenta la corrupción	Introducir dilema moral
Secundaria	Esquiva / Dash	Movimiento rápido con cooldown	Gestión de riesgo
Secundaria	Salto	Evitar obstáculos y ataques	Ritmo y lectura del entorno
Secundaria	Transformación progresiva	El caballero cambia visual y mecánicamente según corrupción	Feedback narrativo + mecánico
Terciaria	Mejora del vehículo/armadura	Mejora de estadísticas entre runs	Progresión roguelite
Terciaria	Eventos aleatorios	Encuentros dinámicos en la carretera	Rejugabilidad
Sistema/NPC	IA adaptativa de enemigos	Enemigos cambian comportamiento según estilo del jugador	Castigar patrones repetitivos
Sistema/NPC	Mundo reactivo	El entorno se oscurece o se vuelve hostil según corrupción	Integrar narrativa y mecánica
🔥 Mecánica sistémica destacada

Sistema de Corrupción Dinámica

Si el jugador mata mucho → enemigos más agresivos.

Si evita combates → menos recompensas.

El mundo cambia visualmente (niebla, fuego, criaturas).

Esta mecánica afecta:

IA enemiga

Diseño de niveles

Final narrativo

📖 EJERCICIO 2 – NARRATIVA
🧠 IDEA

Violencia, culpa y redención en una carretera infinita.

🎯 LOGLINE

Un caballero condenado recorre una carretera infinita en busca de redención, pero cada enemigo que derrota lo acerca más a convertirse en aquello que juró destruir.

📜 SINOPSIS

El mundo cayó tras la Guerra de las Órdenes.
Las carreteras están infestadas de criaturas nacidas del odio humano.

El protagonista, un caballero caído, fue quien inició la masacre final que destruyó su reino. Ahora cabalga sin destino, obligado a avanzar eternamente.

En su viaje:

Puede purgar el mal…

O convertirse en su manifestación definitiva.

El mundo no juzga sus palabras.
Solo sus actos.

🏛️ ARQUETIPO NARRATIVO

Arquetipo: Viaje del Héroe Oscuro

Mundo ordinario → Reino en guerra

Llamada a la aventura → Traición y caída

Descenso → Exilio en la carretera infinita

Prueba constante → Combate y corrupción

Crisis → Transformación monstruosa

Resolución → Redención o condena final

Diagrama:
Reino → Traición → Exilio → Viaje infinito → Corrupción → Final múltiple
🧱 ESTRUCTURA NARRATIVA

El juego se divide en “Tramos”.

Cada tramo incluye:

Sección endless

Evento narrativo

Arena de combate

Decisión implícita (violencia vs contención)

Estructura en bucle:
Conducción → Encuentro → Combate → Resultado moral → Cambio del mundo
        ↑__________________________________________|
📚 ELEMENTOS ADICIONALES

Lore fragmentado en objetos

Voces del pasado durante momentos de alta corrupción

Apariciones espectrales del antiguo rey

Cambios visuales progresivos del protagonista

No hay diálogos extensos.
La narrativa es ambiental.

🧍 EJERCICIO 3 – PERSONAJE PRINCIPAL
⚔️ Nombre

Sir Aldric de Valemont

🎯 Importancia

Es el eje mecánico y narrativo.
El sistema de corrupción gira completamente en torno a él.

🧱 Esfera Física

Armadura deteriorada

Capa quemada

Espada reliquia del reino

Transformaciones físicas según corrupción:

Ojos brillantes

Armadura fusionada con carne

Cuernos o grietas luminosas

🧠 Esfera Psicológica

Inicio:

Culpa

Determinación silenciosa

Mitad:

Duda

Justificación de la violencia

Final:

Redención compasiva
o

Aceptación de su monstruosidad

🔄 Transformación

Arco de Redención Trágica.

El jugador decide:

¿Rompe el ciclo?

¿Lo perpetúa?

Todo el diseño mecánico está alineado con esta evolución.

🎮 EJERCICIO 4 – ONBOARDING
🟢 Fase 1 – Tutorial Invisible

Primer tramo:

Solo movimiento y salto

Enemigos débiles

UI mínima

🟡 Fase 2 – Introducción del Combate

Arena sencilla:

Tutorial contextual sin texto

Indicadores visuales de ataque

🔴 Fase 3 – Corrupción

Primer enemigo importante:

Mensaje visual claro

Cambio leve en el personaje

El jugador aprende jugando.

No hay textos largos.
Todo es experiencial.

💰 EJERCICIO 5 – ECONOMÍA
🎮 Modelo de negocio

Indie premium (PC / consola)
Precio estimado: 14,99€

🔁 Economía interna
Recursos:

Fragmentos de memoria (moneda)

Núcleos corruptos (upgrade especial)

Reliquias (mejoras pasivas)

Gasto:

Mejorar daño

Reducir corrupción acumulada

Desbloquear rutas alternativas

📊 Balance económico

Progresión lenta pero constante

Corrupción como “impuesto moral”

No pay-to-win

💵 Estimación básica de desarrollo

Equipo mínimo:

1 diseñador

1 programador

1 artista

1 músico freelance

Duración estimada: 8–10 meses

Presupuesto aproximado:
40.000€ – 70.000€

🧠 EJERCICIO 6 – FRAMEWORK MDA
🎮 MECÁNICAS

Combate

Endless runner

Sistema de corrupción

IA adaptativa

⚙️ DINÁMICAS

Dilema moral constante

Riesgo vs recompensa

Adaptación del jugador

Tensión progresiva

💥 ESTÉTICAS

El jugador debe sentir:

Tensión

Culpa

Poder

Duda

Catarsis final

🎯 Coherencia global

Todo el diseño responde a una pregunta:

¿La violencia justificada deja de ser violencia?

Si quieres, puedo ahora:

Convertirte esto en versión más académica formal

Hacer un PDF estructurado

Añadir portada y maquetación

O endurecerlo más para que suene aún más profesional

¿Es proyecto individual o en grupo?
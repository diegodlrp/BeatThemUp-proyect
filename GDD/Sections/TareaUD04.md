# 🎮 TAREA UD04 - Diseño de Nivel

---

## 🧩 Ejercicio 1: Diseño de nivel

### 📍 Descripción general

El nivel está diseñado como un **semendless runner con transiciones a combate**.  
El jugador avanza en moto hasta encontrarse con zonas de conflicto donde debe bajarse y continuar a pie.

### 🗺️ Estructura del nivel

El nivel se divide en las siguientes etapas:

1. **Inicio (Tutorial suave)**
   - Movimiento básico en moto
   - Sin enemigos

2. **Tramo de velocidad**
   - Obstáculos simples (vehículos, barreras)
   - Introducción a la aceleración

3. **Zona de combate (Burbuja 1)**
   - El jugador se baja de la moto
   - Aparecen enemigos
   - Se introduce el sistema de combate

4. **Zona de reparación**
   - La moto queda dañada
   - El jugador debe repararla antes de continuar

5. **Reanudación**
   - Vuelta a la moto
   - Aumento progresivo de dificultad

---

### 🎯 Objetivos del nivel

- Aprender las mecánicas básicas (movimiento y aceleración)
- Introducir el combate a pie
- Enseñar la mecánica de reparación de la moto
- Superar la primera zona de enemigos

---

### 🚧 Obstáculos

- Barreras en carretera
- Vehículos enemigos
- Enemigos en combate cuerpo a cuerpo
- Daño progresivo de la moto
- Falta de combustible

---

### 🎬 Eventos de ambiente / scripting

- Entrada a zona de combate → transición automática a modo a pie
- Spawn de enemigos en zonas cerradas
- Destrucción parcial de la moto
- Activación de zona de reparación
- Música cambia según estado (exploración / combate)

---

> 🔗 Todos estos elementos están referenciados en la tabla del **Ejercicio 4**

---

## ⚙️ Ejercicio 2: Características del nivel

- **Tipo de nivel:** Lineal con eventos controlados
- **Ritmo:** Alternancia entre velocidad (moto) y combate (a pie)
- **Progresión:** Incremento gradual de dificultad
- **Duración estimada:** 5–10 minutos
- **Curva de aprendizaje:**
  - Movimiento → Aceleración → Combate → Gestión de recursos
- **Rejugabilidad:** Media (dependiendo de desempeño en combate)

---

## 🎨 Ejercicio 3: Referencias visuales (Art Bible)

### 🏍️ Inspiración principal

- Estética post-apocalíptica / carretera
- Ambientes urbanos destruidos
- Sensación de velocidad y peligro

### 🎮 Referencias

- Juegos tipo endless runner
- Beat 'em ups clásicos
- Películas de carretera (ej: estilo Mad Max)

### 🖼️ Elementos visuales clave

- Carreteras largas y rectas
- Colores desaturados
- Efectos de polvo y velocidad
- Animaciones de impacto en combate

---

## 📦 Ejercicio 4: Elementos del nivel

### 🧱 Obstáculos

| Tipo            | Cuándo aparece       | Dónde aparece        | Función |
|-----------------|--------------------|---------------------|--------|
| Barrera         | Tramo inicial       | Carretera           | Enseñar esquivar |
| Vehículo enemigo| Tramo medio         | Carril frontal      | Aumentar dificultad |
| Enemigos melee  | Zona combate        | Área cerrada        | Combate a pie |

---

### 🎁 Recursos / premios

| Tipo        | Cuándo aparece       | Dónde aparece      | Función |
|------------|--------------------|-------------------|--------|
| Combustible | Tras combate        | Zona segura        | Continuar avance |
| Reparación  | Zona específica     | Taller improvisado | Restaurar moto |
| Vida        | Ocasional           | Drops enemigos     | Recuperación |

---

### 🧍 Enemigos

| Tipo         | Comportamiento       | Dificultad |
|-------------|----------------------|-----------|
| Básico      | Ataque frontal       | Baja |
| Rápido      | Movimiento lateral   | Media |
| Pesado      | Ataques lentos       | Alta |

---

## 🔊 Ejercicio 5: Música y sonido

### 🎼 Clasificación de audio

| Tipo | Descripción |
|------|------------|
| **MX (Music)** | Música de fondo (exploración, combate) |
| **SFX** | Sonidos de acciones (golpes, moto, colisiones) |
| **DX** | Diálogos (si aplica) |
| **FOL (Foley)** | Sonidos ambientales (pasos, roces) |
| **BG (Background)** | Ambiente general (viento, carretera) |

---

### 🗺️ Mapa de sonido

- **Audio Listener:** Cámara principal
- **Fuentes de audio:**
  - Moto → sonido constante de motor
  - Enemigos → sonidos localizados
  - Obstáculos → impacto al colisionar
- **Zonas de audio:**
  - Carretera → viento + motor
  - Zona combate → música intensa
  - Zona reparación → sonido ambiente bajo

---

### 🔊 Eventos de sonido

- Aceleración → aumento de tono del motor
- Entrada a combate → cambio de música
- Golpes → SFX contundente
- Reparación → sonido mecánico

---

# ✅ Fin del documento
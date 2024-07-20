# Ejemplo de Arquitectura Basada en Agentes

Este proyecto de ejemplo ilustra una Arquitectura Basada en Agentes (Agent-Based Architecture) utilizando Python. En este caso, hemos creado un escenario simple donde agentes autónomos interactúan para cumplir órdenes específicas.

## Contenido del Proyecto

El proyecto consta de los siguientes archivos:

- **`agent.py`**: Define la clase `Agent` que representa un agente autónomo y la clase `Controller` que gestiona los agentes y las órdenes.
- **`main.py`**: Contiene el código principal para instanciar agentes, agregarlos al controlador y enviar órdenes a los agentes.

## Estructura del Proyecto

├── agent.py
└── main.py



## Funcionamiento

### Agent (`Agente`)

El agente (`Agent`) puede recibir y ejecutar órdenes. Se define con los siguientes métodos:

- `receive_order(order)`: Recibe una orden y llama a `execute_order(order)`.
- `execute_order(order)`: Simula la ejecución de la orden.

### Controller (`Controlador`)

El controlador (`Controller`) gestiona la comunicación entre los agentes. Se define con los siguientes métodos:

- `add_agent(agent)`: Añade un agente a la lista de agentes.
- `send_order(order)`: Envía una orden a todos los agentes añadidos.

### Uso

Para ejecutar el ejemplo:

1. Asegúrate de tener Python instalado en tu sistema.
2. Ejecuta `main.py` desde la línea de comandos con Python:


```
python main.py
```


Esto iniciará el programa y enviará las órdenes `"Recoger paquete"` y `"Entregar paquete"` a los agentes. Verás la salida en la consola que indica las órdenes recibidas y ejecutadas por cada agente.

## Contribución

Siéntete libre de expandir este ejemplo agregando más funcionalidades a los agentes o el controlador según tus necesidades. ¡Las contribuciones son bienvenidas!

---

Este proyecto es un ejemplo básico de cómo implementar una Arquitectura Basada en Agentes en Python para simular interacciones autónomas entre agentes en un entorno controlado.

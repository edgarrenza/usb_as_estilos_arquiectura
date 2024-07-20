# Arquitectura de Eventos - Ejemplo con Python y Flask

Este proyecto implementa un ejemplo básico de Arquitectura de Eventos utilizando Python y Flask. Consiste en tres componentes principales:

1. **Generador de Eventos:** Script para generar eventos aleatorios y publicarlos en un servicio.
2. **Servicio de Publicación de Eventos (`event_broker.py`):** API REST para recibir y almacenar eventos publicados.
3. **Consumidor de Eventos (`event_consumer.py`):** Script para consumir eventos almacenados en el servicio de publicación.

## Requisitos

Asegúrate de tener instalado Python 3 y las bibliotecas requeridas listadas en `requirements.txt`. Puedes instalar las dependencias usando pip:

```bash
pip install -r requirements.txt
```

## Ejecución

### 1. Ejecutar el Servicio de Publicación de Eventos

El servicio de publicación (`event_broker.py`) debe ejecutarse primero. Abre una terminal y ejecuta el siguiente comando:

```bash
python event_broker.py
```

### 3. Ejecutar el Generador de Eventos

Abre una tercera terminal para ejecutar el generador de eventos (`event_generator.py`). Este script simula la generación continua de eventos y los publica en el servicio de publicación:

```bash
python event_generator.py
```

## Prueba

### Publicación de Eventos

Puedes usar curl o un cliente REST como Postman para publicar eventos al servicio de publicación:

```bash
curl -X POST -H "Content-Type: application/json" -d '{"event_id": 1, "timestamp": "2024-07-10 15:00:00", "message": "Evento de prueba"}' http://127.0.0.1:5000/publish-event
```

### Consumo de Eventos

Para verificar los eventos almacenados, puedes acceder al endpoint `/events` del servicio de publicación:

```bash
curl http://127.0.0.1:5000/events
```
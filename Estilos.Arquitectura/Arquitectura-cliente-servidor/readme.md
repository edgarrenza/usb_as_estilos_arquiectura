# Aplicación Cliente-Servidor en Java

Esta aplicación Java implementa una comunicación simple entre un cliente y un servidor mediante sockets.

## Contenido

- [Descripción](#descripción)
- [Instrucciones de Ejecución](#instrucciones-de-ejecución)
- [Mejoras y Funcionalidades Adicionales](#mejoras-y-funcionalidades-adicionales)

## Descripción

La aplicación consiste en dos componentes principales:

- **Cliente**: Inicia una conexión con el servidor, envía mensajes y espera respuestas.
- **Servidor**: Escucha conexiones entrantes, maneja múltiples clientes concurrentes y procesa mensajes según un protocolo simple.

## Instrucciones de Ejecución

### Requisitos Previos

- Java Development Kit (JDK) 11 o superior instalado.
- Maven para la gestión de dependencias y compilación.

### Compilación

Para compilar la aplicación, ejecuta el siguiente comando desde la raíz del proyecto:

```bash
mvn clean package -DskipTests
```


## Contenerización con Docker

Si prefieres ejecutar la aplicación dentro de un contenedor Docker, sigue estos pasos:

1. **Dockerfile**: Utiliza el siguiente Dockerfile para construir la imagen Docker:
   ```dockerfile
   # Usa una imagen base de OpenJDK 11
   FROM openjdk:11

   # Establece el directorio de trabajo dentro del contenedor
   WORKDIR /app

   # Copia el JAR compilado desde tu máquina local al contenedor en /app
   COPY target/Arquitectura-capas-1.0-SNAPSHOT.jar /app/Arquitectura-cliente-servidor-1.0-SNAPSHOT.jar

   # Comando para ejecutar la aplicación cuando se inicie el contenedor
   CMD ["java", "-jar", "/app/Arquitectura-cliente-servidor-1.0-SNAPSHOT.jar"]

## Construcción y Ejecución de la Imagen

Desde el directorio donde se encuentra tu Dockerfile, ejecuta los siguientes comandos:

```bash
docker build -t arquitectura-cliente-servidor .
```
Ejecucion

```bash
docker run -it --rm arquitectura-cliente-servidor
```




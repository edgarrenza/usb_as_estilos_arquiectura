# Arquitectura por Capas - Ejemplo de Aplicación Java

Esta aplicación Java implementa una arquitectura por capas básica para la gestión de usuarios.

## Requerimientos

Para ejecutar esta aplicación necesitas tener instalado:
- Java Development Kit (JDK) 11 o superior
- Maven para compilar el proyecto desde el código fuente

## Clases Principales

- **Main.java**: Clase principal que contiene el bucle principal de la aplicación para gestionar usuarios.
- **UserController.java**: Controlador que gestiona las operaciones CRUD de usuarios.
- **User.java**: Modelo que representa un usuario con atributos como ID, nombre y correo electrónico.
- **UserRepository.java**: Repositorio que maneja el almacenamiento y recuperación de usuarios utilizando una estructura de datos simple en memoria.
- **UserService.java**: Servicio que encapsula la lógica de negocio para las operaciones de usuario.

## Compilación y Ejecución

1. **Compilación**: Desde la raíz del proyecto, ejecuta el siguiente comando para compilar el proyecto:
   ```bash
   mvn clean install


## Ejecución

Una vez compilado, puedes ejecutar la aplicación usando el siguiente comando:

```bash
java -jar target/Arquitectura-capas-1.0-SNAPSHOT.jar
```
Esto iniciará la aplicación y mostrará un menú interactivo en la consola para gestionar usuarios.

## Contenerización con Docker

Si prefieres ejecutar la aplicación dentro de un contenedor Docker, sigue estos pasos:

1. **Dockerfile**: Utiliza el siguiente Dockerfile para construir la imagen Docker:
   ```dockerfile
   # Usa una imagen base de OpenJDK 11
   FROM openjdk:17-jdk-slim

   # Establece el directorio de trabajo dentro del contenedor
   WORKDIR /app

   # Copia el JAR compilado desde tu máquina local al contenedor en /app
   COPY target/Arquitectura-capas-1.0-SNAPSHOT.jar /app/Arquitectura-capas-1.0-SNAPSHOT.jar

   # Comando para ejecutar la aplicación cuando se inicie el contenedor
   CMD ["java", "-jar", "/app/Arquitectura-capas-1.0-SNAPSHOT.jar"]

## Construcción y Ejecución de la Imagen

Desde el directorio donde se encuentra tu Dockerfile, ejecuta los siguientes comandos:

```bash
docker build -t arquitectura-capas .
```
Ejecucion

```bash
docker run -it --rm arquitectura-capas
```
Para ejecutar este ejemplo de arquitectura de capas usted puede usar la imagen que se encuentra en Docker Hub

```bash
docker run -it jhonacevedor/arquitectura-cliente-servidor
```

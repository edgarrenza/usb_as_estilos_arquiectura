# Usa una imagen base de OpenJDK 17-alpine
FROM openjdk:17-jdk-slim

# Establece el directorio de trabajo dentro del contenedor
WORKDIR /app

# Copia el JAR compilado desde tu máquina local al contenedor en /app
COPY Arquitectura-capas-1.0-SNAPSHOT.jar /app/Arquitectura-capas-1.0-SNAPSHOT.jar

# Comando para ejecutar la aplicación cuando se inicie el contenedor
CMD ["java", "-jar", "/app/Arquitectura-capas-1.0-SNAPSHOT.jar"]

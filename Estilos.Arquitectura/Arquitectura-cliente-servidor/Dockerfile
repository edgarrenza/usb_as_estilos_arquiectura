# Usa una imagen base de OpenJDK 11
FROM openjdk:11

# Establece el directorio de trabajo dentro del contenedor
WORKDIR /app

# Copia el JAR compilado desde tu máquina local al contenedor en /app
COPY target/Arquitectura-cliente-servidor-1.0-SNAPSHOT.jar /app/Arquitectura-cliente-servidor-1.0-SNAPSHOT.jar

# Comando para ejecutar la aplicación cuando se inicie el contenedor
CMD ["java", "-jar", "/app/Arquitectura-cliente-servidor-1.0-SNAPSHOT.jar"]

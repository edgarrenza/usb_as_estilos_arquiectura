package org.example;

import org.example.server.Server;
import org.example.client.Client;

import java.io.IOException;
import java.util.Scanner;

public class Main {
    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        // Iniciar el servidor en un hilo separado
        iniciarServidor();

        // Darle un momento al servidor para iniciar
        esperar(1000);

        // Iniciar el cliente
        Client cliente = new Client();
        try {
            cliente.startConnection("127.0.0.1", 6666);

            // Interfaz interactiva para enviar mensajes al servidor
            interactuarConServidor(cliente);

            // Detener la conexión al salir
            cliente.stopConnection();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private static void iniciarServidor() {
        new Thread(() -> {
            try {
                Server server = new Server();
                server.start(6666);
            } catch (IOException e) {
                e.printStackTrace();
            }
        }).start();
    }

    private static void esperar(int milisegundos) {
        try {
            Thread.sleep(milisegundos);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }

    private static void interactuarConServidor(Client cliente) throws IOException {
        boolean continuar = true;
        while (continuar) {
            System.out.print("Ingrese un mensaje para enviar al servidor (o 'exit' para salir): ");
            String mensaje = scanner.nextLine();

            if ("exit".equalsIgnoreCase(mensaje.trim())) {
                continuar = false;
            } else {
                String respuesta = cliente.sendMessage(mensaje);
                System.out.println("Respuesta del servidor: " + respuesta);
            }
        }
    }
}

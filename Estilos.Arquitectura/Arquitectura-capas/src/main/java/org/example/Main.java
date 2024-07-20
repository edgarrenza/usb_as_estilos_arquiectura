package org.example;

import org.example.controller.UserController;
import org.example.model.User;

import java.util.List;
import java.util.Scanner;

public class Main {
    private static final Scanner scanner = new Scanner(System.in);
    private static final UserController userController = new UserController();

    public static void main(String[] args) {
        System.out.println("Bienvenido a la aplicación de gestión de usuarios!");

        while (true) {
            mostrarMenu();

            int opcion = obtenerOpcion();

            switch (opcion) {
                case 1:
                    crearUsuario();
                    break;
                case 2:
                    actualizarUsuario();
                    break;
                case 3:
                    eliminarUsuario();
                    break;
                case 4:
                    listarUsuarios();
                    break;
                case 5:
                    System.out.println("Saliendo de la aplicación...");
                    return;
                default:
                    System.out.println("Opción inválida. Inténtelo de nuevo.");
            }
        }
    }

    private static void mostrarMenu() {
        System.out.println("\nSeleccione una opción:");
        System.out.println("1. Crear usuario");
        System.out.println("2. Actualizar usuario");
        System.out.println("3. Eliminar usuario");
        System.out.println("4. Listar usuarios");
        System.out.println("5. Salir");
    }

    private static int obtenerOpcion() {
        System.out.print("Ingrese el número de la opción deseada: ");
        return scanner.nextInt();
    }

    private static void crearUsuario() {
        System.out.print("Ingrese el ID del usuario: ");
        String id = scanner.next();

        System.out.print("Ingrese el nombre del usuario: ");
        String name = scanner.next();

        System.out.print("Ingrese el correo electrónico del usuario: ");
        String email = scanner.next();

        User newUser = new User(id, name, email);
        userController.saveUser(newUser);
        System.out.println("Usuario creado correctamente.");
    }

    private static void actualizarUsuario() {
        System.out.print("Ingrese el ID del usuario a actualizar: ");
        String id = scanner.next();

        User existingUser = userController.getUserById(id);
        if (existingUser == null) {
            System.out.println("Usuario no encontrado con ID " + id);
            return;
        }

        System.out.print("Ingrese el nuevo nombre del usuario (deje vacío para mantener): ");
        String newName = scanner.next();
        if (!newName.isEmpty()) {
            existingUser.setName(newName);
        }

        System.out.print("Ingrese el nuevo correo electrónico del usuario (deje vacío para mantener): ");
        String newEmail = scanner.next();
        if (!newEmail.isEmpty()) {
            existingUser.setEmail(newEmail);
        }

        userController.updateUser(existingUser);
        System.out.println("Usuario actualizado correctamente.");
    }

    private static void eliminarUsuario() {
        System.out.print("Ingrese el ID del usuario a eliminar: ");
        String id = scanner.next();

        userController.deleteUser(id);
        System.out.println("Usuario con ID " + id + " eliminado correctamente.");
    }

    private static void listarUsuarios() {
        System.out.println("\nListado de usuarios:");

        // Obtener todos los usuarios desde UserController
        List<User> users = userController.getAllUsers();

        if (users.isEmpty()) {
            System.out.println("No hay usuarios registrados.");
        } else {
            for (User user : users) {
                System.out.println("ID: " + user.getId() + ", Nombre: " + user.getName() + ", Email: " + user.getEmail());
            }
        }
    }
}

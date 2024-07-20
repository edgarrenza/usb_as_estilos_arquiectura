package org.example.controller;

import org.example.model.User;
import org.example.service.UserService;

import java.util.List;

public class UserController {
    private UserService userService;

    public UserController() {
        this.userService = new UserService();
    }

    public User getUserById(String id) {
        return userService.getUserById(id);
    }

    public void saveUser(User user) {
        userService.saveUser(user);
    }

    public void updateUser(User user) {
        userService.updateUser(user);
    }

    public void deleteUser(String id) {
        userService.deleteUser(id);
    }

    public List<User> getAllUsers() {
        return userService.getAllUsers();
    }
}

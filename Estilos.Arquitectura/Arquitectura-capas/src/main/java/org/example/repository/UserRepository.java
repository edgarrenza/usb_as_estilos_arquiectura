package org.example.repository;

import org.example.model.User;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class UserRepository {
    private Map<String, User> userDatabase = new HashMap<>();

    public User getUserById(String id) {
        if (id == null || id.trim().isEmpty()) {
            throw new IllegalArgumentException("The user ID cannot be null or empty");
        }
        User user = userDatabase.get(id);
        if (user == null) {
            throw new IllegalArgumentException("User not found with id: " + id);
        }
        return user;
    }

    public void saveUser(User user) {
        if (user == null) {
            throw new IllegalArgumentException("User cannot be null");
        }

        if (user.getId() == null || user.getId().trim().isEmpty()) {
            throw new IllegalArgumentException("User ID cannot be null or empty");
        }

        if (user.getName() == null || user.getName().trim().isEmpty()) {
            throw new IllegalArgumentException("User name cannot be null or empty");
        }

        if (user.getEmail() == null || user.getEmail().trim().isEmpty() || !user.getEmail().contains("@")) {
            throw new IllegalArgumentException("Invalid email address");
        }

        if (userDatabase.containsKey(user.getId())) {
            throw new IllegalArgumentException("User with ID " + user.getId() + " already exists");
        }

        userDatabase.put(user.getId(), user);
    }

    public void updateUser(User user) {
        if (userDatabase.containsKey(user.getId())) {
            userDatabase.put(user.getId(), user);
        } else {
            throw new IllegalArgumentException("User not found with id: " + user.getId());
        }
    }

    public void deleteUser(String id) {
        if (userDatabase.containsKey(id)) {
            userDatabase.remove(id);
        } else {
            throw new IllegalArgumentException("User not found with id: " + id);
        }
    }

    public List<User> getAllUsers() {
        return new ArrayList<>(userDatabase.values());
    }


}

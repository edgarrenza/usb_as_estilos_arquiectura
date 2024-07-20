from flask import Flask, request, jsonify

app = Flask(__name__)

users = {
    '1': {'id': '1', 'name': 'Jhon', 'email': 'jeacevedo92@gmail.com'},
    '2': {'id': '2', 'name': 'edinson', 'email': 'jeacevedo92@gmail.com'}
}

@app.route('/users/<user_id>', methods=['GET'])
def get_user(user_id):
    print(f"Request to get user with ID: {user_id}", flush=True)
    user = users.get(user_id)
    if user:
        print(f"Returning user: {user}")
        return jsonify(user), 200
    print("User not found")
    return jsonify({'message': 'User not found'}), 404

@app.route('/users', methods=['POST'])
def create_user():
    print("ingresa !!!! ", flush=True)
    new_user = request.json
    print(f"Received request to create user: {new_user}")
    users[new_user['id']] = new_user
    print(f"User created: {new_user}")
    return jsonify(new_user), 201

@app.route('/users', methods=['GET'])
def get_all_users():
    print("Request to get all users", flush=True)
    return jsonify(list(users.values())), 200


if __name__ == '__main__':
    app.run(port=5000, debug=True)

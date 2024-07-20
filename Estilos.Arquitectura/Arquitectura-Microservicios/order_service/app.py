from flask import Flask, request, jsonify, abort
import requests

app = Flask(__name__)

orders = []

@app.route('/orders', methods=['POST'])
def create_order():
    order = request.json
    user_id = order.get('user_id')

    print(f"Received request to create order: {order}", flush=True)

    # Verificar si el usuario existe en el servicio de usuarios
    user_response = requests.get(f'http://127.0.0.1:5000/users/{user_id}')
    print(f"User service response: {user_response.status_code}", flush=True)

    if user_response.status_code != 200:
        print(f"User not found for user_id: {user_id}", flush=True)
        return jsonify({'message': 'User not found'}), 404

    orders.append(order)
    print(f"Order created successfully: {order}")
    return jsonify(order), 201

@app.route('/orders', methods=['GET'])
def get_orders():
    print("Received request to get all orders")
    return jsonify(orders), 200

@app.route('/orders/<int:order_id>', methods=['GET'])
def get_order(order_id):
    print(f"Received request to get order with ID: {order_id}")
    order = next((order for order in orders if order['order_id'] == order_id), None)
    if order:
        print(f"Returning order: {order}")
        return jsonify(order), 200
    print(f"Order not found for ID: {order_id}")
    return jsonify({'message': 'Order not found'}), 404

@app.route('/orders/<int:order_id>', methods=['PUT'])
def update_order(order_id):
    print(f"Received request to update order with ID: {order_id}")
    order = request.json
    existing_order = next((o for o in orders if o['order_id'] == order_id), None)
    if not existing_order:
        print(f"Order not found for update with ID: {order_id}")
        return jsonify({'message': 'Order not found'}), 404

    existing_order.update(order)
    print(f"Order updated successfully: {existing_order}")
    return jsonify(existing_order), 200

@app.route('/orders/<int:order_id>', methods=['DELETE'])
def delete_order(order_id):
    print(f"Received request to delete order with ID: {order_id}")
    global orders
    orders = [o for o in orders if o['order_id'] != order_id]
    print(f"Order deleted successfully with ID: {order_id}")
    return '', 204

if __name__ == '__main__':
    app.run(port=5001, debug=True)

from flask import Flask, request, jsonify

app = Flask(__name__)

events = []

@app.route('/publish-event', methods=['POST'])
def publish_event():
    event_data = request.json
    events.append(event_data)
    return jsonify({'message': 'Event published successfully'}), 201

@app.route('/events', methods=['GET'])
def get_events():
    return jsonify(events), 200

if __name__ == '__main__':
    app.run(port=5000, debug=True)

from flask import Flask, jsonify, request

app = Flask(__name__)

@app.route('/send-email', methods=['POST'])
def send_email():
    email_data = request.json
    recipient = email_data.get('recipient')
    message = email_data.get('message')
    # Lógica para enviar el correo electrónico
    print(f"Sending email to {recipient}: {message}")
    return jsonify({'message': 'Email sent'}), 200

if __name__ == '__main__':
    app.run(port=5002)

import requests
import time
import random

def generate_event():
    event_id = random.randint(1, 100)
    event_data = {
        'event_id': event_id,
        'timestamp': time.strftime('%Y-%m-%d %H:%M:%S'),
        'message': f'Event {event_id} generated'
    }
    response = requests.post('http://127.0.0.1:5000/publish-event', json=event_data)
    print(f'Sent event: {event_data}')
    time.sleep(3)  # Simulate event generation interval

if __name__ == '__main__':
    while True:
        generate_event()

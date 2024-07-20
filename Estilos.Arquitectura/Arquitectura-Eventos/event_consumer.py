import requests
import time

def consume_events():
    while True:
        response = requests.get('http://127.0.0.1:5000/events')
        events = response.json()
        print(f'Received events: {events}')
        time.sleep(5)

if __name__ == '__main__':
    consume_events()

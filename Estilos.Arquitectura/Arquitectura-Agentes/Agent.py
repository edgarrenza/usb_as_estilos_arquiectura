class Agent:
    def __init__(self, name):
        self.name = name

    def receive_order(self, order):
        print(f"{self.name} recibió la orden: {order}")
        self.execute_order(order)

    def execute_order(self, order):
        print(f"{self.name} está ejecutando la orden: {order}")
        # Aquí iría la lógica para ejecutar la orden
        print(f"{self.name} ha completado la orden: {order}")

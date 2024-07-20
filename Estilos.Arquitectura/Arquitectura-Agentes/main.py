from Agent import Agent
from Controller import  Controller
# Crear agentes
agent1 = Agent("Agente 1")
agent2 = Agent("Agente 2")

# Crear controlador y añadir agentes
controller = Controller()
controller.add_agent(agent1)
controller.add_agent(agent2)

# Enviar órdenes a los agentes
controller.send_order("Recoger paquete")
controller.send_order("Entregar paquete")

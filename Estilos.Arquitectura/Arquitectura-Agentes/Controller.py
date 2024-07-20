class Controller:
    def __init__(self):
        self.agents = []

    def add_agent(self, agent):
        self.agents.append(agent)

    def send_order(self, order):
        for agent in self.agents:
            agent.receive_order(order)

import time

class DataProcessor:
    def process_data(self, input_file, output_file):
        # Simular procesamiento de datos que toma tiempo
        print(f"Procesando datos del archivo {input_file}...")
        time.sleep(3)  # Simulando un proceso que toma 3 segundos
        print(f"Datos procesados exitosamente. Guardando en {output_file}")

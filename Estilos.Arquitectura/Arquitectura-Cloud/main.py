from cloud_storage import CloudStorage
from data_processing import DataProcessor

def main():
    # Configuración del almacenamiento en la nube (AWS S3 en este ejemplo)
    bucket_name = 'bucket-arquitectura'
    cloud_storage = CloudStorage(bucket_name)

    # Subir archivo a la nube
    file_to_upload = 'data.csv'
    cloud_storage.upload_file(file_to_upload, 'datos/data.csv')

    # Procesar datos en la nube
    input_file = 'datos/data.csv'
    output_file = 'resultado.csv'

    data_processor = DataProcessor()
    data_processor.process_data(input_file, output_file)

if __name__ == "__main__":
    main()

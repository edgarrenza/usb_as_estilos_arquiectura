import boto3  # Ejemplo usando AWS S3, ajustar según el proveedor de servicios en la nube

class CloudStorage:
    def __init__(self, bucket_name):
        self.bucket_name = bucket_name
        self.s3_client = boto3.client('s3')  # Cliente para AWS S3

    def upload_file(self, file_path, object_name):
        try:
            self.s3_client.upload_file(file_path, self.bucket_name, object_name)
            print(f"Archivo {object_name} cargado exitosamente en {self.bucket_name}")
        except Exception as e:
            print(f"Error al cargar el archivo en {self.bucket_name}: {str(e)}")

    def download_file(self, object_name, file_path):
        try:
            self.s3_client.download_file(self.bucket_name, object_name, file_path)
            print(f"Archivo {object_name} descargado exitosamente a {file_path}")
        except Exception as e:
            print(f"Error al descargar el archivo desde {self.bucket_name}: {str(e)}")

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Storage.V1;

namespace VeterinaryClinicApp
{
    public class FirebaseStorageHelper
    {
        private readonly StorageClient storageClient;
        private readonly string bucketName = "veterinaryclinic-60d24.appspot.com";

        public FirebaseStorageHelper()
        {
            // Initialize the Google Cloud Storage client
            storageClient = StorageClient.Create();
        }

        // Upload PDF to Firebase Storage
        public async Task UploadPdfToStorage(string pdfFilePath, string storagePath)
        {
            try
            {
                using (var fileStream = File.OpenRead(pdfFilePath))
                {
                    var objectName = storagePath; // path where the file will be stored in Firebase Storage
                    await storageClient.UploadObjectAsync(bucketName, objectName, "application/pdf", fileStream);
                    Console.WriteLine($"PDF uploaded to {storagePath}.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error uploading PDF: {ex.Message}");
            }
        }
    }
}

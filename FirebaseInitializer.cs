using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Firebase.Storage;

namespace VeterinaryClinicApp
{
    public class FirebaseInitializer
    {
        private static FirebaseApp _firebaseApp;

        public static FirebaseApp InitializeFirebase(string serviceAccountPath)
        {
            if (_firebaseApp == null)
            {
                _firebaseApp = FirebaseApp.Create(new AppOptions()
                {
                    Credential = GoogleCredential.FromFile(serviceAccountPath)
                });
            }

            return _firebaseApp;
        }
    }
}

using Google.Cloud.Firestore;
namespace VeterinaryClinicApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new mainform());
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", @"D:\capstone2\codings\netcore\VeterinaryClinicApp\veterinaryclinic-60d24-firebase-adminsdk-ptgn7-ab06babd4f.json");
            FirestoreDb db = FirestoreDb.Create("veterinaryclinic-60d24");
            FirebaseInitializer.InitializeFirebase("D:\\capstone2\\codings\\netcore\\VeterinaryClinicApp\\veterinaryclinic-60d24-firebase-adminsdk-ptgn7-ab06babd4f.json");
        }
    }
}
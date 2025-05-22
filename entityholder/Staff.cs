using Google.Cloud.Firestore;
namespace VeterinaryClinicApp
{
    [FirestoreData]
    public class Staff
    {
        [FirestoreProperty("staffName")] public string staffname { get; set; }
        [FirestoreProperty("staffAge")] public string staffage { get; set; }
        [FirestoreProperty("staffGender")] public string gender { get; set; }
        [FirestoreProperty("staffRole")] public string Role { get; set; }
        [FirestoreProperty("image")] public string pbProfile { get; set; }
        [FirestoreDocumentId] public string DocumentID { get; set; }
    }
}

using Google.Cloud.Firestore;
namespace VeterinaryClinicApp
{
    [FirestoreData]
    public class User
    {
        [FirestoreProperty("createdAt")] public Timestamp CreatedAt { get; set; }
        [FirestoreProperty("birthdate")] public Timestamp Birthdate { get; set; }
        [FirestoreProperty("address")] public string Address { get; set; }
        [FirestoreProperty("email")] public string Email { get; set; }
        [FirestoreProperty("fullName")] public string FullName { get; set; }
        [FirestoreProperty("gender")] public string Gender { get; set; }
        [FirestoreProperty("phoneNumber")] public string PhoneNumber { get; set; }
        [FirestoreProperty("loyaltypoints")] public string LoyaltyPoints { get; set; }
        [FirestoreProperty("RFIDTag")] public string rfidTag { get; set; }
        [FirestoreDocumentId] public string DocumentID { get; set; }
    }
}

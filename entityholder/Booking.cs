using Google.Cloud.Firestore;
namespace VeterinaryClinicApp
{
    [FirestoreData]
    public class Booking
    {
        [FirestoreProperty("Time")] public string Time { get; set; }
        [FirestoreProperty("Service")] public string Service { get; set; }
        [FirestoreProperty("Product")] public string Product { get; set; }
        [FirestoreProperty("PaymentMethod")] public string PaymentMethod { get; set; }
        [FirestoreProperty("Animal")] public string Animal { get; set; }
        [FirestoreProperty("Date")] public string Date { get; set; }
        [FirestoreProperty("totalPrice")] public int TotalPrice { get; set; }
        [FirestoreProperty("userId")] public string UserId { get; set; }
        [FirestoreProperty("referenceID")] public long ReferenceID { get; set; }
        [FirestoreProperty("createdAt")] public Timestamp CreatedAt { get; set; }
        [FirestoreProperty("read")] public bool Read { get; set; }
        [FirestoreProperty("Status")] public string Status { get; set; }
        [FirestoreProperty("status")] public string status { get; set; }
        [FirestoreDocumentId]public string DocumentID { get; set;}
    }
}

using Google.Cloud.Firestore;
namespace VeterinaryClinicApp
{
    [FirestoreData]
    public class Transaction
    {
        [FirestoreProperty("userId")] public string UserId { get; set; }
        [FirestoreProperty("service")] public string Service { get; set; }
        [FirestoreProperty("product")] public string Product { get; set; }
        [FirestoreProperty("paymentMethod")] public string PaymentMethod { get; set; }
        [FirestoreProperty("animal")] public string Animal { get; set; }
        [FirestoreProperty("date")] public string Date { get; set; }
        [FirestoreProperty("time")] public string Time { get; set; }
        [FirestoreProperty("totalPrice")] public int TotalPrice { get; set; }
        [FirestoreProperty("paidAmount")] public int AmountPaid { get; set; }
        [FirestoreProperty("referenceID")] public long ReferenceID { get; set; }
        [FirestoreProperty("createdAt")] public Timestamp CreatedAt { get; set; }
        [FirestoreProperty("Status")] public string Status { get; set; }
        [FirestoreProperty("message")] public string Message { get; set; }
        [FirestoreDocumentId] public string DocumentID { get; set; }
    }
}

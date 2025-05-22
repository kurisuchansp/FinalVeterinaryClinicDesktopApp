using Google.Cloud.Firestore;
namespace VeterinaryClinicApp
{
    [FirestoreData]
    public class Sale
    {
        [FirestoreProperty] public string Product { get; set; }
        [FirestoreProperty] public string Service { get; set; }
        [FirestoreProperty] public int TotalPrice { get; set; }
        [FirestoreProperty] public string Date { get; set; }
    }
}

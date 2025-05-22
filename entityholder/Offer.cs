using Google.Cloud.Firestore;
namespace VeterinaryClinicApp
{
    [FirestoreData]
    public class Offer
    {
        [FirestoreProperty] public string OfferName { get; set; }
        [FirestoreProperty] public string OfferType { get; set; }
        [FirestoreProperty] public string Price { get; set; }
        [FirestoreProperty] public string Description { get; set; }
        [FirestoreProperty] public string Image { get; set; }
        [FirestoreProperty] public string OfferUID { get; set; }
    }
}

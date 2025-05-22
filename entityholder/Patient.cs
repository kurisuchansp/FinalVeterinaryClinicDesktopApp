using Google.Cloud.Firestore;
namespace VeterinaryClinicApp
{
    [FirestoreData]
    public class Patient
    {
        [FirestoreProperty]public string DocumentID { get; set; }
        [FirestoreProperty]public string userId { get; set; }
        [FirestoreProperty]public string OwnerName { get; set; }
        [FirestoreProperty]public string PetName { get; set; }
        [FirestoreProperty]public string AnimalGroup { get; set; }
        [FirestoreProperty]public string PetAge { get; set; }
        [FirestoreProperty]public string PetBreed { get; set; }
        private DateTime _admissionDate;
        [FirestoreProperty]public DateTime AdmissionDate 
        { 
            get => _admissionDate; 
            set => _admissionDate = value.Kind == DateTimeKind.Utc ? value : value.ToUniversalTime(); 
        }
        [FirestoreProperty]public string ProfileImage { get; set; }
        [FirestoreProperty]public string Findings { get; set; }
    }
}

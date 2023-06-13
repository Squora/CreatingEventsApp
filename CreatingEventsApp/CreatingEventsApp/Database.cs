using CreatingEventsApp.Models;
using Firebase.Database;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using System.Diagnostics;
using System.Net;

public class Database
{
    private GroupInfoModel _groupInfoModel = new GroupInfoModel();

    public Database()
    {
        string path = "/Users/squor/source/repos/CreatingEventsApp/CreatingEventsApp/Firebase/creatingeventsapp-firebase-adminsdk-n6tgh-abd8e9873e.json";
        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
    }

    public async Task<DocumentSnapshot> GetDocument(string documentId)
    {
        FirebaseApp.Create(new AppOptions()
        {
            Credential = GoogleCredential.GetApplicationDefault()
        });
        FirestoreDb firestoreDb = FirestoreDb.Create("creatingeventsapp");
        DocumentReference docRef = firestoreDb.Collection("Groups").Document(documentId);
        DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

        if (snapshot.Exists)
        {
            Console.WriteLine("Документ найден:");
            Debug.WriteLine("Work");
            Console.WriteLine($"ID: {snapshot.Id}");
            Console.WriteLine($"Данные: {snapshot.ToDictionary()}");
        }
        else
        {
            Debug.WriteLine("Work but didnt find");
            Console.WriteLine("Документ не найден.");
        }

        return snapshot;
    }

    ////FirestoreDb db = FirestoreDb.Create("creatingeventsapp");

    //DocumentReference documentReference = db.Collection("Groups").Document("FaNO23P2FP8hiP4aKuiD");
    //DocumentSnapshot snapshot = await documentReference.GetSnapshotAsync();
    //if (snapshot.Exists)
    //{
    //    Dictionary<string, object> group = snapshot.ToDictionary();
    //}

    //CollectionReference collectionRef = db.Collection("Groups");
    //QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

    //if (snapshot != null)
    //{
    //    foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
    //    {
    //        Dictionary<string, object> documentData = documentSnapshot.ToDictionary();

    //        _groupInfoModel.GroupNumber = documentData["GroupNumber"].ToString();
    //    }
    //}
}
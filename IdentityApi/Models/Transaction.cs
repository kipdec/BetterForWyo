namespace IdentityApi.Models {
    public class Transaction {
        // A unique identifier for the document
        public long DocumentId { get; set; }
        // The signature of the provider    
        public string Signature { get; set; }
    }
}
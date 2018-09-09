namespace IdentityApi.Models {
    public class Document {
        // A unique identifier for the document
        public long DocumentId { get; set; }
        // The signature of the provider    
        public string Signature { get; set; }
        // The encrypted message
        public string Message { get; set; }
    }
}
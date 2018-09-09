
using System;
using System.IO;
using Newtonsoft.Json;

namespace IdentityApi.Models {
    public class Identity {
        public long Id { get; set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public DateTime DOB {get; set;}
        public DateTime BeginningOfResidence {get; set;}

        public string PublicKey {get; set;}
    }
}
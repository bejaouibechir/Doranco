using System.Runtime.Serialization;

namespace MessageContractProjet
{
    [DataContract]
    public class SecretData
    {
        [DataMember]
        public string SecretMessage { get; set; }
    }
}

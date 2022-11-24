using System.ServiceModel;

namespace MessageContractProjet
{

    [MessageContract(IsWrapped = true, WrapperName = "SecretBodyResponse",
        WrapperNamespace = "http://www.doranco.com/2022/4/SecretDataResponse")]
    public class SecretDataResponse
    {
        public SecretDataResponse() : this(new SecretData { SecretMessage=string.Empty })
        {
                
        }
        
        public SecretDataResponse(SecretData secret)
        {
            Secret = secret;
        }

        [MessageBodyMember(Name = "Secret", Namespace = "http://www.doranco.com/2022/4/Secret")]
        public SecretData Secret { get; set; }
    }
}

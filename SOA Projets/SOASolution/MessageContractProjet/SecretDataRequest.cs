using System.ServiceModel;

namespace MessageContractProjet
{

    [MessageContract(IsWrapped =true,WrapperName ="SecretBodyRequest",
        WrapperNamespace = "http://www.doranco.com/2022/4/SecretDataRequest")]
    public class SecretDataRequest
    {
        public SecretDataRequest():this(new SecretData { SecretMessage= string.Empty})
        {

        }

        public SecretDataRequest(SecretData secret)
        {
            Secret = secret;
        }
        
        
        [MessageHeader(Name ="Hash",Namespace = "http://www.doranco.com/2022/4/Hash")]
        public int Hash { get; set; }

        [MessageBodyMember(Name ="Secret",Namespace = "http://www.doranco.com/2022/4/Secret")]
        public SecretData Secret { get; set; }
    }
}

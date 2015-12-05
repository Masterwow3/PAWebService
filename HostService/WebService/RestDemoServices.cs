using System.ServiceModel;
using System.ServiceModel.Activation;

namespace WebService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        ConcurrencyMode = ConcurrencyMode.Single,
        IncludeExceptionDetailInFaults = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestDemoServices:IRESTDemoServices
    {
        
        public string GetClientNameById(string id)
        {
            return "Geiler Affe";
        }
    }
}
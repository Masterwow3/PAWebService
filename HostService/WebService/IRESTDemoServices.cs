using System.ServiceModel;
using System.ServiceModel.Web;

namespace WebService
{
    [ServiceContract(Name = "RestDemoServices")]
    public interface IRESTDemoServices
    {
        [OperationContract]
        [WebGet(UriTemplate = Routing.GetClientRoute, BodyStyle = WebMessageBodyStyle.Bare)]
        string GetClientNameById(string id);
    }
}
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    [ServiceContract]
    public interface IServiceTicket:IDisposable
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/Add/",
            Method = "POST")]
        Ticket Add(Ticket ticket);


        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        ICollection<Ticket> GetAlls();

        [OperationContract]
        [WebGet(UriTemplate = "/Customer/{id}", ResponseFormat = WebMessageFormat.Json)]
        Product Get(string id);


        // TODO: agregue aquí sus operaciones de servicio
    }
}

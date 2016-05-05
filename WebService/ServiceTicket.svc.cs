using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceTicket : ServiceBase,IServiceTicket
    {
        readonly IServiceTicket _service;
        public ServiceCustomer(IServiceTicket service)
        {
            _service = service;
        }
        public Ticket Add(Ticket ticket)
        { 
            return _service.Add(ticket);
        }
        public IEnumerable<Ticket> GetAlls()
        {
            return _service.GetAlls();
        }
        public Product Get(string id)
        {
            int id_int = Convert.ToInt32(id);
            return _service.Get(id_int);
        }

    }

    }
}

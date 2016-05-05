using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceProduct" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceProduct.svc o ServiceProduct.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceProduct : ServiceBase,IServiceProduct
    {
        readonly IServiceProduct _service;
        public ServiceProduct(IServiceProduct service)
        {
            _service = service;
        }

        public ICollection<Product> GetAlls()
        {
            return _service.GetAlls();
        }


    }
    
}

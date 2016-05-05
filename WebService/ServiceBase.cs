using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class ServiceBase:IDisposable
    {
        readonly IUnitOfWork _unitofwork;
        public ServiceBase(IUnitOfWork unitofwork)
        {
            if (null == unitofwork)
            {
                throw new ArgumentNullException("unitofwork");
            }
            _unitofwork = unitofwork;

        }
        private int SaveChanges()
        {
            return _unitofwork.SaveChanges();
        }
        public void Dispose()
        {
            _unitofwork.Dispose();
        }
    }
}
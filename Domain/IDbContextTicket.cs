using Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IDbContextTicket:IUnitOfWork
    {
        IDbSet<Ticket> Ticket { get; set; }
    }
}

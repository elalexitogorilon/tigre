using System.Linq;
using DALocean.DataAccess;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.EntityService
{
    public class OceanTicket: ContextConnection, IOceanTicket
    {

        private IBaseRepository<tbl_Ticket> ticket;

        
        public OceanTicket(IBaseRepository<tbl_Ticket> ticket)
        {
            ContextOcean = true;
            this.ticket = ticket;
        }

        public OceanTicket()
        {
            ContextOcean = true;
            ticket = new Repository<tbl_Ticket>(Context);
        }

        public IQueryable<tbl_Ticket> GetTickets()
        {
            return ticket.All();
        }
        public tbl_Ticket GetTickets(int id)
        {
            return ticket.Find(x=>x.Factura_Pk == id);
        }
        public void InsertTickets(tbl_Ticket entity)
        {
            ticket.Create(entity);
            ticket.Save();
        }
        public void UpdateTickets(tbl_Ticket entity)
        {
            ticket.Update(entity);
            Save();
        }
        public void DeleteTickets(tbl_Ticket entity)
        {
            ticket.Delete(entity);
            Save();
        }
        public void Save()
        {
            ticket.Save();
        }

    }
}

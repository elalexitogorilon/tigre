using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALocean.DataAccess;
namespace PrompRepositories.Services.Interfaces
{
     public interface IOceanTicket
    {
        IQueryable<tbl_Ticket> GetTickets();
        tbl_Ticket GetTickets(int id);
        void InsertTickets(tbl_Ticket entity);
        void UpdateTickets(tbl_Ticket entity);
        void DeleteTickets(tbl_Ticket entity);
        void Save();
    }
}

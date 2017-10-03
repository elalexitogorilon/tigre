using System.Linq;
using DALTiger;
using PrompRepositories.Services.Interfaces;
using Repositories.BaseInterface;
using PrompRepositories.Services.DBconnection;
using Repositories.Repository;

namespace PrompRepositories.Services.Interfaces
{
    public interface IPaymentTypes
    {
        IQueryable<PaymentType> GetEmails();
        PaymentType GetPaymentType(int id);
        void InsertPaymenttype(PaymentType entity);
        void UpdatePaymenttype(PaymentType entity);
        void DeletePaymenttype(PaymentType entity);
    }
}

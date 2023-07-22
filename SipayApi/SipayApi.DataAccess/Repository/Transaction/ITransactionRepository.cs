using SipayApi.DataAccess.Domain;
using SipayApi.DataAccess.Repository.Base;
using System.Linq.Expressions;

namespace SipayApi.DataAccess.Repository;

    public interface ITransactionRepository :IGenericRepository<Transaction>
    {
        List<Transaction> GetByReference(string reference);
        List<Transaction> GetByParameter(Expression<Func<Transaction, bool>> expression);
}


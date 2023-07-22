using SipayApi.DataAccess.Domain;
using SipayApi.DataAccess.Repository.Base;
using System.Linq.Expressions;

namespace SipayApi.DataAccess.Repository;

    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
    private readonly SimDbContext dbContext;
        public TransactionRepository(SimDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Transaction> GetByReference(string reference)
        {
            return dbContext.Set<Transaction>().Where(x => x.ReferenceNumber == reference).ToList();
        }

        public List<Transaction> GetByParameter(Expression<Func<Transaction, bool>> expression)
        {
            return dbContext.Set<Transaction>().Where(expression).ToList();
        }
}

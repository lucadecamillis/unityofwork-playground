using System.Threading.Tasks;
using uow.playground.Context;
using uow.playground.Contract.Interfaces;

namespace uow.playground.Repositories
{
	public class UnityOfWork : IUnityOfWork
	{
        readonly DbContext dbContext;

        public UnityOfWork(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

		public Task<int> Commit()
		{
            return Task.FromResult(0);
		}
	}
}
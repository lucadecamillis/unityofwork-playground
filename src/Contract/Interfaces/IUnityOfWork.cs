using System.Threading.Tasks;

namespace uow.playground.Contract.Interfaces
{
	public interface IUnityOfWork
	{
		/// <summary>
		/// Saves all pending changes
		/// </summary>
		/// <returns>The number of objects in an Added, Modified, or Deleted state</returns>
		Task<int> Commit();
	}
}
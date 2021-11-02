using uow.playground.Contract.Interfaces;

namespace uow.playground.Services
{
	public class EntityService : IEntityService
	{
		readonly IEntityRepository entityRepository;
		readonly IDependencyRepository dependencyRepository;
		readonly IUnityOfWork unityOfWork;

		public EntityService(
			IEntityRepository entityRepository,
			IDependencyRepository dependencyRepository,
			IUnityOfWork unityOfWork)
		{
			this.entityRepository = entityRepository;
			this.dependencyRepository = dependencyRepository;
			this.unityOfWork = unityOfWork;
		}
	}
}
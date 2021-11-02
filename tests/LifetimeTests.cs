using Unity;
using Unity.Lifetime;
using uow.playground.Context;
using uow.playground.Contract.Interfaces;
using uow.playground.Repositories;
using uow.playground.Services;
using Xunit;

namespace uow.playground.tests
{
	public class LifetimeTests
	{
		[Fact]
		public void Lifetime_AssureDisposed()
		{
			IUnityContainer container = WireUp();

			DbContext dbContext = container.Resolve<DbContext>();

			Assert.False(dbContext.Disposed);

			container.Dispose();

			Assert.True(dbContext.Disposed);
		}

		private IUnityContainer WireUp()
		{
			IUnityContainer container = new UnityContainer();

			container.RegisterType<DbContext>(new ContainerControlledLifetimeManager());
			container.RegisterType<IUnityOfWork, UnityOfWork>();
			container.RegisterType<IEntityRepository, EntityRepository>();
			container.RegisterType<IDependencyRepository, DependencyRepository>();
			container.RegisterType<IEntityService, EntityService>();

			return container;
		}
	}
}
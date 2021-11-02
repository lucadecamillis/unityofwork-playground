using System;

namespace uow.playground.Context
{
	public class DbContext : IDisposable
	{
		public bool Disposed { get; set; }

		public void Dispose()
		{
			this.Disposed = true;
		}
	}
}
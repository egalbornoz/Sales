namespace Sales.Domain.Modelos
{
	using System.Data.Entity;
	public class DataContext : DbContext
	{
		public DataContext() : base("DefaultConnection")
		{

		}

		public System.Data.Entity.DbSet<Sales.Common.Modelos.Productos> Productos { get; set; }
	}

}

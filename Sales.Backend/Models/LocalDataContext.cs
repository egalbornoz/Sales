namespace Sales.Backend.Models
{
	using Domain.Modelos;
	public class LocalDataContext : DataContext
	{
		public System.Data.Entity.DbSet<Sales.Common.Modelos.Productos> Productos { get; set; }
	}
}
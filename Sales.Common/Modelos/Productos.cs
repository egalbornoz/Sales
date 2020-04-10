
namespace Sales.Common.Modelos
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class Productos
	{
		[Key]
		public int IdProducto { get; set; }
		[Required]
		public string Descripcion { get; set; }
		public decimal Precio { get; set; }
		public bool Disponible { get; set; }
		public DateTime HoraPublicacion { get; set; }
	}
}

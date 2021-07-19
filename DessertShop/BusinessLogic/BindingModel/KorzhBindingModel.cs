using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModel
{
	public class KorzhBindingModel
	{
		public int? Id { get; set; }
		public string Name { get; set; }
		public double Cost { get; set; }
		public int? DessertId { get; set; }
		public int DessertStatus { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.ViewModel
{
	public class FillingViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Cost { get; set; }
		public int DessertId { get; set; }
		public int DessertStatus { get; set; }
	}
}

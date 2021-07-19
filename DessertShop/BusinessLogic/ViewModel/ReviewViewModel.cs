using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.ViewModel
{
	public class ReviewViewModel
	{
		public int? Id { get; set; }
		public int UserId { get; set; }
		public int DessertStatus { get; set; }
		public int DessertId { get; set; }
		public string Text { get; set; }
		public int Rate { get; set; }
	}
}

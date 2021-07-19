using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.ViewModel
{
	public class CupcakeViewModel
	{
		public int? Id { get; set; }
		public string Name { get; set; }
		public int Filling { get; set; }
		public int Count { get; set; }
		public string SmallDesc { get; set; }
		public double Cost { get; set; }
		public string ImgName { get; set; }
	}
}

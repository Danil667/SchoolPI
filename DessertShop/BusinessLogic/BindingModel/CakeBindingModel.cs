using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModel
{
	public class CakeBindingModel
	{
		public int? Id { get; set; }
		public string Name { get; set; }
		public int Filling { get; set; }
		public string SmallDesc { get; set; }
		public int Korzh { get; set; }
		public int Weight { get; set; }
		public double Cost { get; set; }
		public string ImgName { get; set; }
	}
}

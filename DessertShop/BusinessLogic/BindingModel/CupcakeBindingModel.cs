﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModel
{
	public class CupcakeBindingModel
	{
		public int? Id { get; set; }
		public string Name { get; set; }
		public int Filling { get; set; }
		public string SmallDesc { get; set; }
		public int Count { get; set; }
		public double Cost { get; set; }
		public string ImgName { get; set; }
	}
}

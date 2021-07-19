using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BindingModel
{
	public class UserBindingModel
	{
		public int? Id { get; set; }
		public int Status { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
	}
}

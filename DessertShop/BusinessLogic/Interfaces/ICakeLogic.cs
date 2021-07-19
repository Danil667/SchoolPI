using BusinessLogic.BindingModel;
using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
	public interface ICakeLogic
	{
		List<CakeViewModel> Read(CakeBindingModel model);
		void CreateOrUpdate(CakeBindingModel model);
		void Delete(CakeBindingModel model);
	}
}

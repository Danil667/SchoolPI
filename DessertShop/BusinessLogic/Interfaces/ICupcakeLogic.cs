using BusinessLogic.BindingModel;
using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
	public interface ICupcakeLogic
	{
		List<CupcakeViewModel> Read(CupcakeBindingModel model);
		void CreateOrUpdate(CupcakeBindingModel model);
		void Delete(CupcakeBindingModel model);
	}
}

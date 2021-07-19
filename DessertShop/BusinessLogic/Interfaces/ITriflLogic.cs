using BusinessLogic.BindingModel;
using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
	public interface ITriflLogic
	{
		List<TriflViewModel> Read(TriflBindingModel model);
		void CreateOrUpdate(TriflBindingModel model);
		void Delete(TriflBindingModel model);
	}
}

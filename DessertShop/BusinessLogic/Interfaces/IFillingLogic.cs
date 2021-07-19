using BusinessLogic.BindingModel;
using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
	public interface IFillingLogic
	{
		List<FillingViewModel> Read(FillingBindingModel model);
		void CreateOrUpdate(FillingBindingModel model);
		void Delete(FillingBindingModel model);
	}
}

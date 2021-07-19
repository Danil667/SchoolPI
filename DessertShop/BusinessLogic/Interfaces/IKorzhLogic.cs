using BusinessLogic.BindingModel;
using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
	public interface IKorzhLogic
	{
		List<KorzhViewModel> Read(KorzhBindingModel model);
		void CreateOrUpdate(KorzhBindingModel model);
		void Delete(KorzhBindingModel model);
	}
}

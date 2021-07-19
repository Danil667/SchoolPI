using BusinessLogic.BindingModel;
using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
	public interface IReviewLogic
	{
		List<ReviewViewModel> Read(ReviewBindingModel model);
		void CreateOrUpdate(ReviewBindingModel model);
	}
}

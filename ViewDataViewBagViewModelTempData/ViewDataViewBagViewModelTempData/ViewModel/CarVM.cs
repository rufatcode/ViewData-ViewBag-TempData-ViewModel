using System;
using ViewDataViewBagViewModelTempData.Models;

namespace ViewDataViewBagViewModelTempData.ViewModel
{
	public class CarVM
	{
		public List<Marka> Markas{get;set;}
        public List<Model> Models { get; set; }
        public CarVM()
		{
			Markas = new List<Marka>();
			Models = new List<Model>();
		}
	}
}


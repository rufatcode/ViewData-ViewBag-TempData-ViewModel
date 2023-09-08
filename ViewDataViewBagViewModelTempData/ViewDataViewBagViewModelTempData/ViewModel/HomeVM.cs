using System;
using ViewDataViewBagViewModelTempData.Model;

namespace ViewDataViewBagViewModelTempData.ViewModel
{
	public class HomeVM
	{
		public List<City> Cities { get; set; }
		public List<Country> Countries { get; set; }
		public HomeVM()
		{
			Cities = new List<City>();
		}
	}
}


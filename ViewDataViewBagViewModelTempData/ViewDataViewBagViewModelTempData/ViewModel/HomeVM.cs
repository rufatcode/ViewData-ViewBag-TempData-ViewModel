using System;
using ViewDataViewBagViewModelTempData.Models;

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


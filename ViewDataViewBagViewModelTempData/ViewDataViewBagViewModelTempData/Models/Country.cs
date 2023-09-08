using System;
namespace ViewDataViewBagViewModelTempData.Model
{
	public class Country
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<City> Cities { get; set; }
		public Country()
		{
			Cities = new List<City>();
		}
	}
}


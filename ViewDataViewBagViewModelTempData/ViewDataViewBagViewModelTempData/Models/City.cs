﻿using System;
namespace ViewDataViewBagViewModelTempData.Models
{
	public class City
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Country Country { get; set; }
		public int CountryId { get; set; }
		public City()
		{
		}
	}
}


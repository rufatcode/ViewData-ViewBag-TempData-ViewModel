using System;
using System.ComponentModel.DataAnnotations;

namespace ViewDataViewBagViewModelTempData.Models
{
	public class Marka
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Model> Models { get; set; }
		public Marka()
		{
			Models = new List<Model>();
		}
	}
}


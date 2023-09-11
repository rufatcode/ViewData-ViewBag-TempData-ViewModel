using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViewDataViewBagViewModelTempData.Models
{
	public class Model
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public Marka Marka { get; set; }
		[ForeignKey(nameof(Marka))]
		public int MarkaId { get; set; }
		public Model()
		{
		}
	}
}


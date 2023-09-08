using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewDataViewBagViewModelTempData.Model;
using ViewDataViewBagViewModelTempData.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ViewDataViewBagViewModelTempData.Controllers
{
    public class HomeController : Controller
    {
        private List<City> _cities = new()
        {
            new(){Id=1,Name="Baku",CountryId=1},
            new(){Id=2,Name="Barda",CountryId=1},
            new(){Id=3,Name="Quba",CountryId=1},
            new(){Id=4,Name="Moldova",CountryId=2},
            new(){Id=5,Name="Istanbul",CountryId=3},
            new(){Id=6,Name="Ankara",CountryId=3},
            new(){Id=7,Name="Moskova",CountryId=4},
            new(){Id=8,Name="Pekin",CountryId=5},
            new(){Id=9,Name="Kiyev",CountryId=6},
            new(){Id=10,Name="Dombos",CountryId=6},
            new(){Id=11,Name="Berlin",CountryId=7},
            new(){Id=12,Name="Ajax",CountryId=8},
            new(){Id=13,Name="Barcelona",CountryId=9},
            new(){Id=14,Name="Madrid",CountryId=9},
        };
        private List<Country> _countries = new()
        {
            new(){Id=1,Name="Azerbaijan"},
            new(){Id=2,Name="Irlandiya"},
            new(){Id=3,Name="Turkiye"},
            new(){Id=4,Name="Rusiya"},
            new(){Id=5,Name="Hindistan"},
            new(){Id=6,Name="Ukraniya"},
            new(){Id=7,Name="Almaniya"},
            new(){Id=8,Name="Hollandiya"},
            new(){Id=9,Name="Ispaniya"},
        };
        private HomeVM _homeVM = new();
        public HomeController()
        {
            foreach (var city in _cities)
            {
                foreach (var country in _countries)
                {
                    if (city.CountryId==country.Id)
                    {
                        country.Cities.Add(city);
                        city.Country = country;
                    }
                }
            }
            _homeVM.Cities = _cities;
            _homeVM.Countries = _countries;
        }
        
        public IActionResult Index()
        {
          
            return View(_homeVM);
        }
        public IActionResult City(int ?id)
        {
            if (id==null)
            {
                return View(_homeVM.Cities);
            }
            if (_cities.Any(item=>item.Id==id))
            {
                return View(_homeVM.Cities.FindAll(item => item.Id == id));
            }
            return NotFound();
        }
        public IActionResult Country(int? groupId)
        {
            if (groupId==null)
            {
                return View(_homeVM.Countries);
            }
            if (_homeVM.Countries.Any(item=>item.Id==groupId))
            {
                return View(_homeVM.Countries.FindAll(item=>item.Id==groupId));
            }
            return NotFound();
        }
    }
}


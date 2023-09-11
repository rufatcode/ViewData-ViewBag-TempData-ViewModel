using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewDataViewBagViewModelTempData.Models;
using ViewDataViewBagViewModelTempData.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ViewDataViewBagViewModelTempData.Controllers
{
    public class CarController : Controller
    {
        private List<Marka> _markas  = new()
            {
                new(){Id=1,Name="BMV"},
                new(){Id=2,Name="AUDI"},
                new(){Id=3,Name="Mercedes"},
                new(){Id=4,Name="Kia"},
                new(){Id=5,Name="Toyota"},
                new(){Id=6,Name="Hunday"},
                new(){Id=7,Name="Honda"},
                new(){Id=8,Name="Ferrari"},
                new(){Id=9,Name="Porche"},
                new(){Id=10,Name="Dodge"},
                new(){Id=11,Name="Lambargine"},
                new(){Id=12,Name="Chevralet"},
            };
        private List<Model> _models = new()
            {
                new(){Id=1,Name="325",MarkaId=1},
                new(){Id=2,Name="M3",MarkaId=1},
                new(){Id=3,Name="M5",MarkaId=1},
                new(){Id=4,Name="M6",MarkaId=1},
                new(){Id=5,Name="M8",MarkaId=1},
                new(){Id=6,Name="G90",MarkaId=1},
                new(){Id=7,Name="A1",MarkaId=2},
                new(){Id=8,Name="A3",MarkaId=2},
                new(){Id=9,Name="A5",MarkaId=2},
                new(){Id=10,Name="AMG GT 53",MarkaId=3},
                new(){Id=11,Name="AMG GT 63 S",MarkaId=3},
                new(){Id=12,Name="C 200",MarkaId=3},
                new(){Id=13,Name="Besta",MarkaId=4},
                new(){Id=14,Name="Auris",MarkaId=5},
                new(){Id=15,Name="Avalon",MarkaId=5},
                new(){Id=16,Name="City",MarkaId=6},
                new(){Id=17,Name="fit",MarkaId=7},
                new(){Id=18,Name="HR-V",MarkaId=7},
                new(){Id=19,Name="458 italiana",MarkaId=8},
                new(){Id=20,Name="911 camera",MarkaId=9},
                new(){Id=21,Name="Cayenne",MarkaId=9},
                new(){Id=22,Name="Dart",MarkaId=10},
                new(){Id=23,Name="Urus",MarkaId=11},
                new(){Id=24,Name="Alero",MarkaId=12},
            };
        private CarVM _carVM  = new();
        public CarController()
        {
            foreach (var marka in _markas)
            {
                foreach (var model in _models)
                {
                    if (marka.Id==model.MarkaId)
                    {
                        marka.Models.Add(model);
                        model.Marka = marka;
                    }
                }
            }
            _carVM.Markas = _markas;
            _carVM.Models = _models;

        }
        public IActionResult Index()
        {
            TempData["Demo"] ="temp";
            ViewBag.Demo = "Bag";
            ViewData["Data"] = "Data";
            return View(_carVM);
        }
        public IActionResult Marka(int ? id)
        {
            if (id==null)
            {
                return View(_markas);
            }
            if (_markas.Any(item=>item.Id==id))
            {
                return View(_markas.FindAll(item => item.Id == id));
            }
            return NotFound();
        }
        public IActionResult Model(int ? id)
        {
            if (id==null)
            {
                return View(_models);
            }
            if (_models.Any(item=>item.Id==id))
            {
                return View(_models.FindAll(item => item.Id == id));
            }
            return BadRequest();
        }
    }
}


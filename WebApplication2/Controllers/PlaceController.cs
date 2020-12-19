using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PlaceController : Controller
    {
        public IActionResult Museums()  //yerini Place/List aldı
        {  //PlacesRepository aracılığı ie ulaştığımız Places leri view üzerine gönderiypruz.
            return View(PlaceRepository.Places);
        }
        public IActionResult Historical()
        {
            return View(PlaceRepository.Places);
        }
        public IActionResult Religious()
        {
            return View(PlaceRepository.Places);
        }
        public IActionResult SF()
        {
            return View(PlaceRepository.Places);
        }
        public IActionResult PA()
        {
            return View(PlaceRepository.Places);
        }
        public IActionResult Park()
        {
            return View(PlaceRepository.Places);
        }
        public IActionResult Trip(int id)
        {
            return View(PlaceRepository.Places.First(i => i.Id == id ));
        }
    }
}
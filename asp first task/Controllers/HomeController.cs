using asp_first_task.Entities;
using asp_first_task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace asp_first_task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Drinks()
        {
            var Drinks = new List<Drink>
                {
                    new Drink{Id=1, Name="Ayran", Price=1.5},
                    new Drink{Id=2, Name="Sprite", Price=3.2},
                    new Drink{Id=3, Name="Pepsi", Price=3.2},
                };
            return View(Drinks);
        }
        public IActionResult HotMeals()
        {
            var HotMeals = new List<HotMeal>
                {
                    new HotMeal{Id=1,Name="Dolma",Price=4.4},
                    new HotMeal{Id=2,Name="Piti",Price=4.3},
                    new HotMeal{Id=3,Name="Plov",Price=5.8},
                };
            return View(HotMeals);
        }
        public IActionResult FastFoods()
        {
            var FastFoods = new List<FastFood>
                {
                    new FastFood{Id=1,Name="Hamburger",Price=3.0},
                    new FastFood{Id=2,Name="Sandwich",Price=3.6},
                    new FastFood{Id=3,Name="Pizza",Price=15.2},
                };
            return View(FastFoods);
        }

        public IActionResult All()
        {
            MainViewModel vm = new MainViewModel
            {
                Drinks = new List<Drink>
                {
                    new Drink{Id=1, Name="Ayran", Price=1.5},
                    new Drink{Id=2, Name="Sprite", Price=3.2},
                    new Drink{Id=3, Name="Pepsi", Price=3.2},
                },
                HotMeals = new List<HotMeal>
                {
                    new HotMeal{Id=1,Name="Dolma",Price=4.4},
                    new HotMeal{Id=2,Name="Piti",Price=4.3},
                    new HotMeal{Id=3,Name="Plov",Price=5.8},
                },
                FastFoods = new List<FastFood>
                {
                    new FastFood{Id=1,Name="Hamburger",Price=3.0},
                    new FastFood{Id=2,Name="Sandwich",Price=3.6},
                    new FastFood{Id=3,Name="Pizza",Price=15.2},
                }
            };
            return View(vm);
        }
    }
}
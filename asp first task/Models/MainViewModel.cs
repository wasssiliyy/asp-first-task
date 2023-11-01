using asp_first_task.Entities;

namespace asp_first_task.Models
{
    public class MainViewModel
    {
        public List<Drink>? Drinks { get; set; }
        public List<HotMeal>? HotMeals { get; set; }
        public List<FastFood>? FastFoods { get; set; }

    }
}

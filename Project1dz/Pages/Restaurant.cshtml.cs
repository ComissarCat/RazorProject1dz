using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Project1dz.Pages
{
    public class RestaurantModel : PageModel
    {
        public string Name { get; private set; } = "Хавательная";
        public string Address { get; private set; } = "Ул. Пушкина д. Колотушкина";
        public string[] Menu { get; private set; } = ["Еда", "Пища", "Хавчик", "Обед"];
        public void OnGet()
        {
        }
    }
}

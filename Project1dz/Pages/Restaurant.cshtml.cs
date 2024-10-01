using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Project1dz.Pages
{
    public class RestaurantModel : PageModel
    {
        public string Name { get; private set; } = "�����������";
        public string Address { get; private set; } = "��. ������� �. �����������";
        public string[] Menu { get; private set; } = ["���", "����", "������", "����"];
        public void OnGet()
        {
        }
    }
}

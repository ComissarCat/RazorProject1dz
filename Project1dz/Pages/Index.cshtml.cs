using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Project1dz.Pages
{
	public class IndexModel : PageModel
    {
        public string[] Restaurants { get; private set; } = ["�����������", "����������������", "���������������"];
        public void OnGet()
        {
        }
    }
}

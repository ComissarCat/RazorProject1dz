using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Project1dz.Pages
{
	public class CountriesModel : PageModel
	{
		public string[] Countries { get; private set; } = ["����", "������", "��������"];

		public void OnGet()
		{
		}
	}
}

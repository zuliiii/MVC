namespace RNET102.UI.ViewComponents;
using Microsoft.AspNetCore.Mvc;
public class BlogViewComponent : ViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync()
	{
		var blogs = Models.Seed.BlogSeedData;

		return View(model: blogs);
	}

}

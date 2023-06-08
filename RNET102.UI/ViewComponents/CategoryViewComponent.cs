using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RNET102.UI.DataAccess;
namespace RNET102.UI.ViewComponents;

public class CategoryViewComponent : ViewComponent
{
	private readonly AppDbContext _context;
    public CategoryViewComponent(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IViewComponentResult> InvokeAsync()
	{
        
		return View(_context.Categories.ToListAsync());

	}

}

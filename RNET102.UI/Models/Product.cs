using System.ComponentModel;

namespace RNET102.UI.Models;

public class Product
{
	public int Id { get; set; }
	public int CategoryID { get; set; }
	public string Name { get; set; }
	public decimal Price { get; set; }
	public string ImageUrl { get; set; }
	
	public Category category { get; set; }
}

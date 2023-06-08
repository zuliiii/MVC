namespace RNET102.UI.Models;

public class Blog
{
	public int Id { get; set; }
	public string ImageUrl { get; set; } = null!;
	public DateTime PublishDate { get; set; }
	public string Title { get; set; } = null!;
	public string Content { get; set; } = null!;

	
}

public static class Seed
{
	public static List<Blog> BlogSeedData = new()
	{
		new Blog {Title ="Natus error sit voluptatem", 
			Content ="Donec porta diam eu massa. Quisque diam lorem, interdum vitae, dapibus ac, scelerisque vitae, pede. Donec eget tellus non erat lacinia fermentum.",
			ImageUrl="https://img.freepik.com/free-vector/nature-scene-background-with-rainbow-sky_1308-73033.jpg?w=360", 
			PublishDate = DateTime.Now.AddDays(-1)},
		new Blog {Title ="Sed ut perspiciatis unde omnis iste",
			Content ="Donec porta diam eu massa. Quisque diam lorem, interdum vitae, dapibus ac, scelerisque vitae, pede. Donec eget tellus non erat lacinia fermentum.",
			ImageUrl="https://img.freepik.com/free-vector/nature-scene-background-with-rainbow-sky_1308-73033.jpg?w=360",
			PublishDate = DateTime.Now.AddDays(-2)},
		new Blog {Title ="Donec sagittis euismod purus",
			Content ="Donec porta diam eu massa. Quisque diam lorem, interdum vitae, dapibus ac, scelerisque vitae, pede. Donec eget tellus non erat lacinia fermentum.",
			ImageUrl="https://img.freepik.com/free-vector/nature-scene-background-with-rainbow-sky_1308-73033.jpg?w=360",
			PublishDate = DateTime.Now.AddDays(-3)},
		new Blog {Title ="Natus successs sit voluptatem",
			Content ="Donec porta diam eu massa. Quisque diam lorem, interdum vitae, dapibus ac, scelerisque vitae, pede. Donec eget tellus non erat lacinia fermentum.",
			ImageUrl="https://img.freepik.com/free-vector/nature-scene-background-with-rainbow-sky_1308-73033.jpg?w=360",
			PublishDate = DateTime.Now.AddDays(-4)},
		new Blog {Title ="gdsjhfd error sit voluptatem",
			Content ="Donec porta diam eu massa. Quisque diam lorem, interdum vitae, dapibus ac, scelerisque vitae, pede. Donec eget tellus non erat lacinia fermentum.",
			ImageUrl="https://img.freepik.com/free-vector/nature-scene-background-with-rainbow-sky_1308-73033.jpg?w=360",
			PublishDate = DateTime.Now.AddDays(-5)},
	};
}

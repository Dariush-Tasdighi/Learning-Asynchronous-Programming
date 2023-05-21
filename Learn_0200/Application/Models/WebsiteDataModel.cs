namespace Models;
//namespace Application.Models;

public class WebsiteDataModel : object
{
	public WebsiteDataModel(string url) : base()
	{
		Url = url;
	}

	//public string Url { get; set; }
	//public string Url { get; private set; }
	//public string Url { get; }
	public string Url { get; init; }

	public string? Content { get; set; }

	public int ContentLength
	{
		get
		{
			if (Content is null)
			{
				return 0;
			}
			else
			{
				return Content.Length;
			}
		}
	}
}

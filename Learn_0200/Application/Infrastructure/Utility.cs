namespace Infrastructure;

public static class Utility : object
{
	static Utility()
	{
	}

	public static System.Collections.Generic.IList<string> GetWebsiteUrls()
	{
		var result =
			new System.Collections.Generic.List<string>();

		result.Add(item: "https://dartil.com");
		result.Add(item: "http://date2date.ir");
		result.Add(item: "https://www.jabama.com");
		result.Add(item: "https://www.farsnews.ir");
		result.Add(item: "https://www.digikala.com");
		result.Add(item: "https://www.iranianexperts.ir");

		return result;
	}
}

namespace Application;

public partial class Form3 : Infrastructure.BaseForm
{
	public Form3() : base()
	{
		InitializeComponent();
	}

	//private void RunButton_Click
	//	(object sender, System.EventArgs e)
	//{
	//	var watch =
	//		System.Diagnostics.Stopwatch.StartNew();

	//	DownloadWebsitesAsync();

	//	watch.Stop();

	//	var elapsedMilliseconds =
	//		watch.ElapsedMilliseconds;

	//	resultTextBox.Text +=
	//		$"Total Execution Time: {elapsedMilliseconds:#,##0} Milliseconds";
	//}

	/// <summary>
	/// New
	/// </summary>
	private async void RunButton_Click
		(object sender, System.EventArgs e)
	{
		var watch =
			System.Diagnostics.Stopwatch.StartNew();

		await DownloadWebsitesAsync();

		watch.Stop();

		var elapsedMilliseconds =
			watch.ElapsedMilliseconds;

		resultTextBox.Text +=
			$"Total Execution Time: {elapsedMilliseconds:#,##0} Milliseconds";
	}

	/// <summary>
	/// New
	/// </summary>
	//private void DownloadWebsites()
	private async System.Threading.Tasks.Task DownloadWebsitesAsync()
	{
		var websitesUrls =
			Infrastructure.Utility.GetWebsiteUrls();

		foreach (var websitesUrl in websitesUrls)
		{
			// **************************************************
			//var output =
			//	DownloadWebsite
			//	(websiteUrl: websitesUrl);
			// **************************************************

			// **************************************************
			//var output =
			//	await
			//	System.Threading.Tasks.Task.Run
			//	(() => DownloadWebsite(websiteUrl: websitesUrl));

			//ReportWebsiteData(websiteData: output);
			// **************************************************

			// **************************************************
			// Error! Cross-thread operation not valid
			// **************************************************
			//await System.Threading.Tasks.Task.Run(() =>
			//{
			//	var output =
			//		DownloadWebsite(websiteUrl: websitesUrl);

			//	ReportWebsiteData(websiteData: output);
			//});
			// **************************************************

			// **************************************************
			var output =
				await
				System.Threading.Tasks.Task.Run(() =>
				{
					var result =
						DownloadWebsite(websiteUrl: websitesUrl);

					return result;
				});

			ReportWebsiteData(websiteData: output);
			// **************************************************
		}
	}

	private Models.WebsiteDataModel DownloadWebsite(string websiteUrl)
	{
		var result =
			new Models.WebsiteDataModel(url: websiteUrl);

		var client =
			new System.Net.WebClient();

		result.Content =
			client.DownloadString(address: websiteUrl);

		return result;
	}

	private void ReportWebsiteData
		(Models.WebsiteDataModel websiteData)
	{
		resultTextBox.Text +=
			$"{websiteData.Url} downloaded: {websiteData.ContentLength:#,##0} Characters long.";

		resultTextBox.Text +=
			System.Environment.NewLine;
	}

	private void ClearButton_Click
		(object sender, System.EventArgs e)
	{
		resultTextBox.Text = string.Empty;

		runButton.Focus();
	}
}

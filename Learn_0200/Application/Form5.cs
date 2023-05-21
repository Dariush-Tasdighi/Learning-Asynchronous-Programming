namespace Application;

public partial class Form5 : Infrastructure.BaseForm
{
	public Form5() : base()
	{
		InitializeComponent();
	}

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
	private async System.Threading.Tasks.Task DownloadWebsitesAsync()
	{
		var websitesUrls =
			Infrastructure.Utility.GetWebsiteUrls();

		var tasks =
			new System.Collections.Generic
			.List<System.Threading.Tasks.Task<Models.WebsiteDataModel>>();

		foreach (var websitesUrl in websitesUrls)
		{
			//var resultTask =
			//	System.Threading.Tasks.Task.Run
			//	(() => DownloadWebsite(websiteUrl: websitesUrl));

			var resultTask =
				DownloadWebsiteAsync(websiteUrl: websitesUrl);

			tasks.Add(item: resultTask);
		}

		await System.Threading.Tasks.Task.WhenAll(tasks: tasks);

		foreach (var task in tasks)
		{
			var output = await task;

			ReportWebsiteData(websiteData: output);
		}
	}

	/// <summary>
	/// New
	/// </summary>
	//private Models.WebsiteDataModel DownloadWebsite(string websiteUrl)
	private async System.Threading.Tasks.Task
		<Models.WebsiteDataModel> DownloadWebsiteAsync(string websiteUrl)
	{
		var result =
			new Models.WebsiteDataModel(url: websiteUrl);

		//var client =
		//	new System.Net.WebClient();

		var client =
			new System.Net.Http.HttpClient();

		result.Content =
			await
			client.GetStringAsync(requestUri: websiteUrl);

		return result;
	}

	private void ReportWebsiteData
		(Models.WebsiteDataModel websiteData)
	{
		resultTextBox.Text +=
			$"{websiteData.Url} downloaded: {websiteData.ContentLength} Characters long.";

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

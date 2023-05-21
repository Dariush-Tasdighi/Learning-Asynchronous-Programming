namespace Application;

public partial class Form4 : Infrastructure.BaseForm
{
	public Form4() : base()
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
	/// New - Parallel
	/// </summary>
	private async System.Threading.Tasks.Task DownloadWebsitesAsync()
	{
		var websitesUrls =
			Infrastructure.Utility.GetWebsiteUrls();

		// دقت کنید که دستور ذیل غلط است
		//var tasks =
		//	new System.Collections.Generic
		//	.List<System.Threading.Tasks.Task>();

		var tasks =
			new System.Collections.Generic
			.List<System.Threading.Tasks.Task<Models.WebsiteDataModel>>();

		foreach (var websitesUrl in websitesUrls)
		{
			var resultTask =
				System.Threading.Tasks.Task.Run
				(() => DownloadWebsite(websiteUrl: websitesUrl));

			tasks.Add(item: resultTask);
		}

		await System.Threading.Tasks.Task.WhenAll(tasks: tasks);

		foreach (var task in tasks)
		{
			var output = await task;

			ReportWebsiteData(websiteData: output);
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

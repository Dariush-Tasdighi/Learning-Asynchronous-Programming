namespace Application;

public partial class Form6 : Infrastructure.BaseForm
{
	public Form6() : base()
	{
		InitializeComponent();
	}

	private System.Threading.CancellationToken CancellationToken;

	private async void RunButton_Click
		(object sender, System.EventArgs e)
	{
		var watch =
			System.Diagnostics.Stopwatch.StartNew();

		await DownloadWebsitesAsync(cancellationToken: CancellationToken);

		watch.Stop();

		var elapsedMilliseconds =
			watch.ElapsedMilliseconds;

		resultTextBox.Text +=
			$"Total Execution Time: {elapsedMilliseconds:#,##0} Milliseconds";
	}

	/// <summary>
	/// New
	/// </summary>
	private async System.Threading.Tasks.Task DownloadWebsitesAsync
		(System.Threading.CancellationToken cancellationToken = default)
	{
		var websitesUrls =
			Infrastructure.Utility.GetWebsiteUrls();

		var tasks =
			new System.Collections.Generic
			.List<System.Threading.Tasks.Task<Models.WebsiteDataModel>>();

		foreach (var websitesUrl in websitesUrls)
		{
			var resultTask = DownloadWebsiteAsync
				(websiteUrl: websitesUrl, cancellationToken: cancellationToken);

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
	private async System.Threading.Tasks.Task<Models.WebsiteDataModel> DownloadWebsiteAsync
		(string websiteUrl, System.Threading.CancellationToken cancellationToken = default)
	{
		var result =
			new Models.WebsiteDataModel(url: websiteUrl);

		var client =
			new System.Net.Http.HttpClient();

		result.Content =
			await client.GetStringAsync
			(requestUri: websiteUrl, cancellationToken: cancellationToken);

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

	private void CancelButton_Click
		(object sender, System.EventArgs e)
	{
	}
}

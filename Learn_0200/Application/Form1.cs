namespace Application;

public partial class Form1 : Infrastructure.BaseForm
{
	public Form1() : base()
	{
		InitializeComponent();
	}

	private void RunButton_Click
		(object sender, System.EventArgs e)
	{
		var client =
			new System.Net.WebClient();

		var websiteUrl =
			"http://date2date.ir";

		var websiteContent =
			client.DownloadString(address: websiteUrl);

		resultTextBox.Text = websiteContent;
	}

	private void ClearButton_Click
		(object sender, System.EventArgs e)
	{
		resultTextBox.Text = string.Empty;

		runButton.Focus();
	}
}

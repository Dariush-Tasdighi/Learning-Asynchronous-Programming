namespace Application;

internal static class Program : object
{
	static Program()
	{
	}

	[System.STAThread]
	private static void Main()
	{
		ApplicationConfiguration.Initialize();

		var mainForm = new MainForm();

		System.Windows.Forms.Application.Run(mainForm: mainForm);

		if (mainForm is not null)
		{
			if (mainForm.IsDisposed == false)
			{
				mainForm.Dispose();
			}

			//mainForm = null;
		}
	}
}

namespace Application;

public partial class MainForm : Infrastructure.BaseForm
{
	public MainForm() : base()
	{
		InitializeComponent();
	}

	private void Sample1Button_Click
		(object sender, System.EventArgs e)
	{
		var myForm = new Form1();

		myForm.ShowDialog();
	}

	private void Sample2Button_Click
		(object sender, System.EventArgs e)
	{
		var myForm = new Form2();

		myForm.ShowDialog();
	}

	private void Sample3Button_Click
		(object sender, System.EventArgs e)
	{
		var myForm = new Form3();

		myForm.ShowDialog();
	}

	private void Sample4Button_Click
		(object sender, System.EventArgs e)
	{
		var myForm = new Form4();

		myForm.ShowDialog();
	}

	private void Sample5Button_Click
		(object sender, System.EventArgs e)
	{
		var myForm = new Form5();

		myForm.ShowDialog();
	}
}

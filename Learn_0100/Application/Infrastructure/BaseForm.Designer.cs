namespace Application.Infrastructure;

partial class BaseForm
{
	private System.ComponentModel.IContainer components = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}

		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	private void InitializeComponent()
	{
		SuspendLayout();
		// 
		// BaseForm
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		ClientSize = new System.Drawing.Size(351, 321);
		Name = "BaseForm";
		StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		ResumeLayout(false);
	}

	#endregion
}

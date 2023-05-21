namespace Application;

partial class Form2
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

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		runButton = new System.Windows.Forms.Button();
		resultTextBox = new System.Windows.Forms.TextBox();
		clearButton = new System.Windows.Forms.Button();
		SuspendLayout();
		// 
		// runButton
		// 
		runButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		runButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		runButton.Location = new System.Drawing.Point(12, 12);
		runButton.Name = "runButton";
		runButton.Size = new System.Drawing.Size(524, 59);
		runButton.TabIndex = 0;
		runButton.Text = "Run";
		runButton.UseVisualStyleBackColor = true;
		runButton.Click += RunButton_Click;
		// 
		// resultTextBox
		// 
		resultTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		resultTextBox.Location = new System.Drawing.Point(12, 142);
		resultTextBox.Multiline = true;
		resultTextBox.Name = "resultTextBox";
		resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		resultTextBox.Size = new System.Drawing.Size(524, 388);
		resultTextBox.TabIndex = 2;
		// 
		// clearButton
		// 
		clearButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		clearButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		clearButton.Location = new System.Drawing.Point(12, 77);
		clearButton.Name = "clearButton";
		clearButton.Size = new System.Drawing.Size(524, 59);
		clearButton.TabIndex = 1;
		clearButton.Text = "&Clear";
		clearButton.UseVisualStyleBackColor = true;
		clearButton.Click += ClearButton_Click;
		// 
		// Form2
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		ClientSize = new System.Drawing.Size(548, 542);
		Controls.Add(clearButton);
		Controls.Add(resultTextBox);
		Controls.Add(runButton);
		Name = "Form2";
		Text = "Form 2";
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private System.Windows.Forms.Button runButton;
	private System.Windows.Forms.TextBox resultTextBox;
	private System.Windows.Forms.Button clearButton;
}

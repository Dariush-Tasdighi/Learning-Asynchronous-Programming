namespace Application;

partial class MainForm
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
		sample1Button = new System.Windows.Forms.Button();
		sample2Button = new System.Windows.Forms.Button();
		sample3Button = new System.Windows.Forms.Button();
		sample4Button = new System.Windows.Forms.Button();
		sample5Button = new System.Windows.Forms.Button();
		sample6Button = new System.Windows.Forms.Button();
		SuspendLayout();
		// 
		// sample1Button
		// 
		sample1Button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		sample1Button.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		sample1Button.Location = new System.Drawing.Point(12, 12);
		sample1Button.Name = "sample1Button";
		sample1Button.Size = new System.Drawing.Size(412, 59);
		sample1Button.TabIndex = 0;
		sample1Button.Text = "Sample 1";
		sample1Button.UseVisualStyleBackColor = true;
		sample1Button.Click += Sample1Button_Click;
		// 
		// sample2Button
		// 
		sample2Button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		sample2Button.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		sample2Button.Location = new System.Drawing.Point(12, 77);
		sample2Button.Name = "sample2Button";
		sample2Button.Size = new System.Drawing.Size(412, 59);
		sample2Button.TabIndex = 1;
		sample2Button.Text = "Sample 2";
		sample2Button.UseVisualStyleBackColor = true;
		sample2Button.Click += Sample2Button_Click;
		// 
		// sample3Button
		// 
		sample3Button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		sample3Button.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		sample3Button.Location = new System.Drawing.Point(12, 142);
		sample3Button.Name = "sample3Button";
		sample3Button.Size = new System.Drawing.Size(412, 59);
		sample3Button.TabIndex = 2;
		sample3Button.Text = "Sample 3";
		sample3Button.UseVisualStyleBackColor = true;
		sample3Button.Click += Sample3Button_Click;
		// 
		// sample4Button
		// 
		sample4Button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		sample4Button.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		sample4Button.Location = new System.Drawing.Point(12, 207);
		sample4Button.Name = "sample4Button";
		sample4Button.Size = new System.Drawing.Size(412, 59);
		sample4Button.TabIndex = 3;
		sample4Button.Text = "Sample 4";
		sample4Button.UseVisualStyleBackColor = true;
		sample4Button.Click += Sample4Button_Click;
		// 
		// sample5Button
		// 
		sample5Button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		sample5Button.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		sample5Button.Location = new System.Drawing.Point(12, 272);
		sample5Button.Name = "sample5Button";
		sample5Button.Size = new System.Drawing.Size(412, 59);
		sample5Button.TabIndex = 4;
		sample5Button.Text = "Sample 5";
		sample5Button.UseVisualStyleBackColor = true;
		sample5Button.Click += Sample5Button_Click;
		// 
		// sample6Button
		// 
		sample6Button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		sample6Button.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		sample6Button.Location = new System.Drawing.Point(12, 337);
		sample6Button.Name = "sample6Button";
		sample6Button.Size = new System.Drawing.Size(412, 59);
		sample6Button.TabIndex = 5;
		sample6Button.Text = "Sample 6";
		sample6Button.UseVisualStyleBackColor = true;
		sample6Button.Click += Sample6Button_Click;
		// 
		// MainForm
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		ClientSize = new System.Drawing.Size(436, 408);
		Controls.Add(sample6Button);
		Controls.Add(sample5Button);
		Controls.Add(sample4Button);
		Controls.Add(sample3Button);
		Controls.Add(sample2Button);
		Controls.Add(sample1Button);
		Name = "MainForm";
		Text = "Main";
		ResumeLayout(false);
	}

	#endregion

	private System.Windows.Forms.Button sample1Button;
	private System.Windows.Forms.Button sample2Button;
	private System.Windows.Forms.Button sample3Button;
	private System.Windows.Forms.Button sample4Button;
	private System.Windows.Forms.Button sample5Button;
	private System.Windows.Forms.Button sample6Button;
}
